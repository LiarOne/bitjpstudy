<template>
    <div>
        <!--图片分类区域-->
        <div id="slider" class="mui-slider">
				<div id="sliderSegmentedControl" class="mui-scroll-wrapper mui-slider-indicator mui-segmented-control mui-segmented-control-inverted">
					<div class="mui-scroll">
						<span :class="['mui-control-item',item.id===0?'mui-active':'']" v-for="item in category" :key="item.id">
							{{item.title}}
                        </span>
					</div>
				</div>

		</div>
        <ul class="lazyul">
            <li v-lazy="item in photolist" :key="item.id">
                <img v-lazy="item.img_url">
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
    background-color: #ddd;
    li{
        img[lazy="loading"]{
            width: 40px;
            height: 300px;
            margin: auto;
        }
    }
}

</style>