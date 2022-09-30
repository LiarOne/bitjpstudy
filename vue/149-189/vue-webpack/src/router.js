import VueRouter from 'vue-router'

import Login from './components/account/Login.vue'
import Reg from './components/account/Reg.vue'

const router = new VueRouter({
    routes: [
        { path: '/login', component: Login },
        { path: '/reg', component: Reg }
    ]
})

export default router