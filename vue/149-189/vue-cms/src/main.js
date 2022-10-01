import Vue from 'vue'
import App from './components/App.vue'

import MintUI from 'mint-ui'
import 'mint-ui/lib/style.css'
Vue.use(MintUI)

import '../lib/mui/css/mui.min.css'
import '../lib/mui/css/icons-extra.css'

import VueRouter from 'vue-router'
Vue.use(VueRouter)
import router from './router.js'

const vm = new Vue({
    el: '#app',
    render: c=>c(App),
    router
})