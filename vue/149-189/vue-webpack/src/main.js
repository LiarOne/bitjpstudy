import Vue from 'vue'
import app from './components/App.vue'

import VueRouter from 'vue-router'
Vue.use(VueRouter)

import router from './router.js'

import MintUI from 'mint-ui'
import 'mint-ui/lib/style.css'
Vue.use(MintUI)

const vm = new Vue({
    el:'#app',
    render: c=>c(app),
    router
})