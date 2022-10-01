import Vue from 'vue'
import App from './components/App.vue'

import MintUI from 'mint-ui'
import 'mint-ui/lib/style.css'
Vue.use(MintUI)

import '../lib/mui/css/mui.min.css'
import '../lib/mui/css/icons-extra.css'

import VueRouter from 'vue-router'
Vue.use(VueRouter)

import HomeContainer from './components/tabbars/HomeContainer.vue'
import MemberContainer from './components/tabbars/MemberContainer.vue'
import ShopcartContainer from './components/tabbars/ShopcartContainer.vue'
import SearchContainer from './components/tabbars/SearchContainer.vue'

const router = new VueRouter({
    routes: [
        { path: '/home', component: HomeContainer },
        { path: '/member', component: MemberContainer },
        { path: '/shopcart', component: ShopcartContainer },
        { path: '/search', component: SearchContainer },
    ]
})

const vm = new Vue({
    el: '#app',
    render: c=>c(App),
    router
})