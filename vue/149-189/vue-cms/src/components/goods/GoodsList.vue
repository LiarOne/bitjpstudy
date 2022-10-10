<template>
    <div>
        <!--商品列表区域-->
        <div class="goods-list">

            <router-link tag="div" :to="'/home/goodsinfo/'+item.id" class="goods-item" v-for="item in goodslist" :key="item.id">
                <img :src="item.img_url" alt="">
                <h1 class="title">{{item.title}}</h1>
                <div class="info">
                    <p class="price">
                        <span class="new">¥ {{item.sell_price}}</span>
                        <span class="old">¥ {{item.market_price}}</span>
                    </p>
                    <p class="sell">
                        <span>热卖中</span>
                        <span>剩{{item.stock_quantity}}件</span>
                    </p>
                </div>
            </router-link>

            <mt-button type="danger" size="large" style="margin-top:10px;" @click="getMore">加载更多</mt-button>

        </div>
    </div>
</template>

<script>
export default {
    data(){
        return {
            page:1,
            goodslist:[]
        }
    },
    created(){
        this.getGoodsListByPage();
    },
    methods: {
        async getGoodsListByPage(){
            const {data} = await this.$http.get("/api/getgoods?pageindex="+this.page);
            if(data.status===0){
                if(data.message.length<=0){ //当获取到的数组长度为0，表示数据已加载完
                    this.isloaded=true; //表示没有新数据了
                }
                this.goodslist=this.goodslist.concat(data.message);
            }
        },
        getMore(){
            if(this.isloaded) return; //如果数据加载完，直接return
            this.page++;
            this.getGoodsListByPage();
        }
    }
}
</script>

<style lang="scss" scoped>
.goods-list {
    display: flex; //设置父盒子为弹性盒模型
    flex-wrap: wrap; //默认内部子元素不会换行，可使用该属性使其换行
    justify-content: space-between;
    padding: 7px;
    padding-top: 0;
    .goods-item{
        width: 49%;
        border: 1px solid #ccc;
        margin-top: 7px;
        box-shadow: 0 0 7px #ccc;
        padding: 2px;
        display: flex;
        flex-direction: column;
        justify-content: space-between;
        img{
            width: 100%;
            min-height: 170px;
        }
        .title{
            font-size: 15px;
        }
        .info{
            background-color: #eee;
            overflow: hidden;
            p {
                margin: 3px;
            }
            .price{
                .new{
                    color: red;
                    font-size: 16px;
                    font-weight: bold;
                    margin-right: 10px;
                }
                .old{
                    text-decoration: line-through;
                    font-size: 12px;
                }
            }
            .sell{
                display: flex;
                justify-content: space-between;
                font-size: 13px;
            }
        }
    }
}
</style>