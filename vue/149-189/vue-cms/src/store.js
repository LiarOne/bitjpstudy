import Vue from 'vue'
import Vuex from 'vuex'
Vue.use(Vuex)

//每当初始化项目的时候，就从localStorage中取一下数据
let car = window.JSON.parse(localStorage.getItem('cart') || '[]')

const store = new Vuex.Store({
    state: {
        cart: car //购物车数组{id,count,selected}
    },
    mutations: {
        addToCar(state,goods){
            let flag = false
            state.cart.some(item=>{  //如果商品在购物车中已有，则只更新数量
                if(item.id == goods.id){
                    item.count += goods.count
                    flag = true;
                    return true;  //some循环中return true可终止后续循环
                }
            })
            if(!flag){
                state.cart.push(goods)   //如果商品在购物车中还没有，则直接加入
            }
            //为了持久化存储购物车数据，把购物车商品序列化出来，存储到localStorage中
            localStorage.setItem('cart', window.JSON.stringify(state.cart))
        },
        delFromCart(state,id){
            state.cart.some((item,i)=>{
                if(item.id==id){
                    state.cart.splice(i,1)
                    return true;
                }
            })
            localStorage.setItem('cart', window.JSON.stringify(state.cart))
        },
        changeSelectState(state,obj){
            state.cart.some(item=>{
                if(item.id==obj.id){
                    item.selected=obj.selected
                    return true
                }
            })
            localStorage.setItem('cart', window.JSON.stringify(state.cart))
        }
    },
    getters: {
        totalcount(state){
            //徽标中商品数量
            let c = 0
            state.cart.forEach(item => c += item.count)
            return c
        },
        idstr(state){
            //获取购物车中所有商品的id字符串
            let arr = []
            state.cart.forEach(item => arr.push(item.id))
            return arr.join(',')
        },
        countObj(state){
            //获取购物车中商品的id和数量的键值对
            let o = {}
            state.cart.forEach(item => o[item.id]=item.count)
            return o;
        },
        selectedObj(state){
            let o = {}
            state.cart.forEach(item => o[item.id]=item.selected)
            return o
        }
    }
})

export default store