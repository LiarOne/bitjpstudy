<template>
    <div>
        <h3>哈哈哈哈</h3>
        <router-link to="/login">登录</router-link>
        <router-link to="/reg">注册</router-link>
        <router-view></router-view>
    </div>
</template>
<script>
    export default {
        data(){
            return {}
        },
        methods: {},
        filters: {},
        components: {},
        directives: {},
        props: {}
    }
</script>
<style>
    h3 {
        color:red;
    }
</style>