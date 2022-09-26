//import Vue from '../node_modules/vue/dist/vue.js' //这里导入的vue和网页中用scripe导入的vue不一样
import Vue from 'vue'

//默认使用import导入的vue不支持如下方式定义组件，只支持使用.vue模板文件来定义
// const login = {
//     template: '<h3>这是Login组件</h3>'
// }

//导入自己的.vue组件
//webpack中使用.vue组件，要安装对应loader
import app from './components/App.vue'
//导入路由模块
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