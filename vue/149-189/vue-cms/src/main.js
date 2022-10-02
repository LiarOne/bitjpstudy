import Vue from 'vue'

import './globalConfig.js'

import VueRouter from 'vue-router'
Vue.use(VueRouter)
import router from './router.js'

import App from './components/App.vue'
const vm = new Vue({
    el: '#app',
    render: c=>c(App),
    router
})