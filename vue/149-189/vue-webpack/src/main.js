import Vue from 'vue'
import app from './components/App.vue'

import VueRouter from 'vue-router'
Vue.use(VueRouter)

import Login from './components/account/Login.vue'
import Reg from './components/account/Reg.vue'

const router = new VueRouter({
    routes: [
        { path: '/login', component: Login },
        { path: '/reg', component: Reg }
    ]
})

const vm = new Vue({
    el:'#app',
    render: c=>c(app),
    router
})