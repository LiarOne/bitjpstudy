<template>
    <div>
        <!--图片分类区域-->
        <div id="slider" class="mui-slider">
				<div id="sliderSegmentedControl" class="mui-scroll-wrapper mui-slider-indicator mui-segmented-control mui-segmented-control-inverted">
					<div class="mui-scroll">
						<span :class="['mui-control-item',item.id===0?'mui-active':'']" v-for="item in category" :key="item.id" @click="getPhotoByCategory(item.id)">
							{{item.title}}
                        </span>
					</div>
				</div>

		</div>
        <ul class="lazyul">
            <li v-lazy="item in photolist" :key="item.id">
                <img v-lazy="item.img_url">
                <div class="info">
                    <h1 class="info-title">{{item.title}}</h1>
                    <div class="info-content">{{item.zhaiyao}}</div>
                </div>
            </li>
        </ul>

    </div>
</template>

<script>
    import mui from '../../../lib/mui/js/mui.js';
    
    export default {
        data(){
            return {
                category:[],
                photolist:[]
            };
        },
        created(){
            this.getPhotoCategory();
            this.getPhotoByCategory(0);
        },
        methods: {
            async getPhotoCategory(){
                const {data} = await this.$http.get('/api/getimgcategory');
                if(data.status===0) {
                    data.message.unshift({title: '全部', id: 0});
                    this.category = data.message;
                }
            },
            async getPhotoByCategory(id){
                const {data} = await this.$http.get('/api/getimages/'+id);
                if(data.status===0) return (this.photolist=data.message);
            }
        },
        mounted(){
            mui('.mui-scroll-wrapper').scroll({deceleration: 0.005})
        }
    };
</script>

<style lang="scss" scoped>
.mui-slider {
    touch-action: pan-x;
}
.lazyul {
    margin: 0;
    padding: 10px;
    li{
        text-align: center;
        background-color: #ccc;
        box-shadow: 0 0 7px gray;
        position: relative;
        & + li {
            margin-top: 10px;
        }
        img {
            vertical-align: middle;
            width: 100%;
        }
        img[lazy="loading"]{
            width: 40px;
            height: 300px;
            margin: auto;
        }
    }
}

.info {
    position: absolute;
    bottom: 0;
    color: #fff;
    background-color: rgba(0,0,0,0.5);
    max-height: 86px;
    overflow: hidden;
    .info-title {
        font-size: 14px;
    }
    .info-content {
        font-size: 13px;
        text-align: left;
        text-indent: 2em;
    }
}

</style>