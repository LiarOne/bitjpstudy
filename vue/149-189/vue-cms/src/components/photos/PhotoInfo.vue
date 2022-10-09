<template>
    <div class="photoinfo-container">
        <h3 class="title">{{photoinfo.title}}</h3>
        <p class="info">
            <span>发表时间：{{photoinfo.add_time | dateFormat}}</span>
            <span>点击：{{photoinfo.click}}次</span>
        </p>
        <hr>
        <!--缩略图区域-->
        <div class="thumb-img-list">
            <img class="preview-img" v-for="(item,index) in photolist" :src="item.src" height="100" @click="$preview.open(index,photolist)" :key="index">
        </div>
        <!--内容区域-->
        <div class="content" v-html="photoinfo.content"></div>
        <!--评论子组件-->
        <comment :newsid="id"></comment>
    </div>
</template>

<script>
import comment from '../sub-components/Comment.vue'

export default {
    data() {
        return {
            photoinfo:{},
            photolist:[]
        };
    },
    created(){
        this.getPhotoInfo();
        this.getThumbImg();
    },
    methods: {
        async getPhotoInfo(){
            const {data} = await this.$http.get('/api/getimageInfo/'+this.id);
            if(data.status===0) return (this.photoinfo=data.message[0]);
        },
        async getThumbImg(){
            const {data} = await this.$http.get('/api/getthumimages'+this.id);
            if(data.status===0) {
                data.message.forEach(item=>{
                    item.w=600;
                    item.h=400;
                })
            }
            this.photolist = data.message;
        }
    },
    props: ["id"],
    components:{
        comment
    }
}
</script>

<style lang="scss" scoped>
.photoinfo-container{
    padding: 3px;
}
.title{
    font-size: 15px;
    text-align: center;
    margin: 15px 0;
    color: #26a2ff;
}
.info{
    font-size: 12px;
    display: flex;
    justify-content: space-between;
}
.content{
    font-size: 13px;
    line-height: 30px;
}
.thumb-img-list{
    img{
        margin: 10px;
        box-shadow: 0 0 7px gray;
    }
}
</style>