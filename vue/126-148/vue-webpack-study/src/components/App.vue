<template>
    <div>
        <h3>哈哈哈</h3>
        <mt-button type="primary" size="normal" plain icon="back">primary</mt-button>
        <router-link to="/login">登录</router-link>
        <router-link to="/reg">注册</router-link>
        <router-view></router-view>
    </div>
</template>

<script>
    import {Toast} from "mint-ui";
    export default {
        data(){
            return {}
        },
        methods:{
            show(){
                //Toast("提示信息");
                Toast({
                    message:'ok',
                    position:'top',
                    duration:2000,
                    iconClass:'icon icon-success'
                })
            }
        },
        filters:{},
        components:{},
        directives:{},
        props:{}
    }
</script>

<style>
    h3 {
        color: red;
    }
</style>