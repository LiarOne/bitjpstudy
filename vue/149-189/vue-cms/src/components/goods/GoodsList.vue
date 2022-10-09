<template>
    <div>
        <!--商品列表区域-->
        <div class="goods-list">

            <div class="goods-item">
                <img src="#" alt="">
                <h1 class="title">小米note 16G双网通版</h1>
                <div class="info">
                    <p class="price">
                        <span class="new">¥2199</span>
                        <span class="old">¥2699</span>
                    </p>
                    <p class="sell">
                        <span>热卖中</span>
                        <span>剩60件</span>
                    </p>
                </div>
            </div>

            <div class="goods-item">
                <img src="#" alt="">
                <h1 class="title">小米note 16G双网通版</h1>
                <div class="info">
                    <p class="price">
                        <span class="new">¥2199</span>
                        <span class="old">¥2699</span>
                    </p>
                    <p class="sell">
                        <span>热卖中</span>
                        <span>剩60件</span>
                    </p>
                </div>
            </div>

            <div class="goods-item">
                <img src="#" alt="">
                <h1 class="title">小米note 16G双网通版</h1>
                <div class="info">
                    <p class="price">
                        <span class="new">¥2199</span>
                        <span class="old">¥2699</span>
                    </p>
                    <p class="sell">
                        <span>热卖中</span>
                        <span>剩60件</span>
                    </p>
                </div>
            </div>

        </div>
    </div>
</template>

<script>
export default {
    data(){
        return {}
    },
    methods: {}
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
        img{
            width: 100%;
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