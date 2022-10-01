import VueRouter from 'vue-router'

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

export default router