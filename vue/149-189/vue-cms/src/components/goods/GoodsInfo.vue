<template>
    <div class="goodsinfo-container">
        <!--轮播图区域-->
        <div class="mui-card">
				<div class="mui-card-content">
					<div class="mui-card-content-inner">
						<swiper :lunbotu="lunbotu" :imgname="'src'" :isfull="false"></swiper>
					</div>
				</div>
		</div>
        <!--商品购买区域---->
        <div class="mui-card">
				<div class="mui-card-header">{{goodsinfo.title}}</div>
				<div class="mui-card-content">
					<div class="mui-card-content-inner">
						<p class="price">
                            市场价：
                            <span style="margin-right:10px;"><del>¥{{goodsinfo.market_price}}</del></span>
                            销售价：
                            <span style="font-size: 16px; color: red; font-weight: bold;">¥{{goodsinfo.sell_price}}</span>
                        </p>
                        <p>
                            购买数量：
                            <span>
                                <!--数字选择框-->
                                <div class="mui-numbox" data-numbox-min='1' data-numbox-max='9'>
					                <button class="mui-btn mui-btn-numbox-minus" type="button">-</button>
					                <input id="test" class="mui-input-numbox" type="number" value="5" />
					                <button class="mui-btn mui-btn-numbox-plus" type="button">+</button>
				                </div>
                            </span>
                        </p>
                        <div>
                            <mt-button type="primary" size="small">立即购买</mt-button>
                            <mt-button type="danger" size="small">加入购物车</mt-button>
                        </div>
					</div>
				</div>
		</div>
        <!--商品参数区域---->
        <div class="mui-card">
				<div class="mui-card-header">商品参数</div>
				<div class="mui-card-content">
					<div class="mui-card-content-inner">
						<p>商品货号：{{goodsinfo.goods_no}}</p>
                        <p>库存情况：{{goodsinfo.stock_quantity}}</p>
                        <p>上架时间：{{goodsinfo.add_time | dateFormat}}</p>
					</div>
				</div>
				<div class="mui-card-footer btnarea">
                    <mt-button type="primary" size="large" plain @click="goDesc">图文介绍</mt-button>
                    <mt-button type="danger" size="large" plain @click="goComment">商品评论</mt-button>
                </div>
		</div>
    </div>
</template>

<script>
import swiper from '../sub-components/Swiper.vue'
import mui from '../../../lib/mui/js/mui.js'

export default {
    data(){
        return {
            lunbotu:[],
            goodsinfo:{}
        }
    },
    created(){
        this.getlunbotu();
        this.getGoodsInfoById();
    },
    mounted(){
        mui(".mui-numbox").numbox()
    },
    methods: {
        async getlunbotu(){
            const {data} = await this.$http.get('/api/getthumimages/'+this.id);
            if(data.status===0) return (this.lunbotu=data.message);
        },
        async getGoodsInfoById(){
            const {data} = await this.$http.get('/api/goods/getinfo/'+this.id);
            if(data.status===0) return (this.goodsinfo=data.message[0]);
        },
        goDesc(){
            this.$router.push("/home/goodsdesc/"+this.goodsinfo.id);
        },
        goComment(){
            this.$router.push("/home/goodscomment/"+this.goodsinfo.id);
        }
    },
    props: ["id"],
    components: {
        swiper
    }
}
</script>

<style lang="scss" scoped>
.goodsinfo-container{
    background-color: #eee;
    overflow: hidden;
}
.btnarea {
    flex-direction: column;
    button + button {
        margin-top: 15px;
    }
}
</style>