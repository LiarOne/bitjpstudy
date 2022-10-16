<template>
    <div class="shopcar-container">
        <div class="goods-list">
            <div class="mui-card" v-for="item in goodslist" :key="item.id">
				<div class="mui-card-content">
					<div class="mui-card-content-inner goods-item">
                        <!--开关-->
						<mt-switch v-model="selectedObj[item.id]" @change="changeSelect(item.id,selectedObj[item.id])"></mt-switch>
                        <!--图片-->
                        <img src="item.thumb_path" alt="">
                        <!--信息区域-->
                        <div class="info">
                            <h1>{{item.title}}</h1>
                            <div class="goods-info">
                                <span class="price">¥{{item.sell_price}}</span>
                                <a href="#" @click.prevent="del(item.id)">删除</a>
                            </div>
                        </div>
					</div>
				</div>
			</div>
            <!--结算区域-->
            <div class="mui-card">
				<div class="mui-card-content">
					<div class="mui-card-content-inner jiesuan">
						<div class="left">
                            <p>总计（不含运费）</p>
                            <p>
                                已勾选商品<span class="danger">0</span>件，总价<span class="danger">¥0</span>
                            </p>
                        </div>
                        <mt-button type="danger">去结算</mt-button>
					</div>
				</div>
			</div>
        </div>
    </div>
</template>

<script>
import {mapGetters,mapMutations} from 'vuex'
export default {
    data(){
        return {
            goodslist:[] //商品列表
        };
    },
    created(){
        this.getGoodsList();
    },
    methods: {
        ...mapMutations(["delFromCart","changeSelectState"]),
        async getGoodsList(){
            if(this.idstr.length<=0)return;
            const {data} = await this.$http.get("/api/goods/getshopcarlist/" + this.idstr);
            if(data.statue===0) return this.goodslist = data.message;
        },
        del(id){
            this.goodslist.some((item,i)=>{
                if(item.id==id){
                    this.goodslist.splice(i,1);
                    return true;
                }
            })
            this.delFromCart(id);
        },
        changeSelect(id,select){
            this.changeSelectState({id,selected:select});
        }
    },
    computed: {
        ...mapGetters(["idstr"])
    }
}
</script>

<style lang="scss" scoped>
.shopcar-container {
    background-color: #eee;
    overflow: hidden;
    .goods-item {
        display: flex;
        img {
            width: 60px;
            height: 60px;
        }
        h1 {
            font-size: 13px;
        }
        .info {
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            .goods-info {
                display: flex;
                justify-content: space-between;
                .price {
                    color: red;
                    font-weight: bold;
                    font-size: 16px;
                }
            }
        }
    }
}
.danger {
    color: red;
    font-weight: bold;
    font-size: 16px;
}
.jiesuan {
    display: flex;
    justify-content: space-between;
    align-items: center;
}
</style>