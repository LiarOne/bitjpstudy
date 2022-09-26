import VueRouter from 'vue-router'
//导入路由相关组件
import Login from './components/account/Login.vue'
import Reg from './components/account/Reg.vue'
//创建路由对象，挂载到vm实例上
const router = new VueRouter({
    routes: [
        { path: '/login', component: Login },
        { path: '/reg', component: Reg }
    ]
})

export default router