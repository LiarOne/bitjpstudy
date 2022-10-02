import VueRouter from 'vue-router'

import HomeContainer from './components/tabbars/HomeContainer.vue'
import MemberContainer from './components/tabbars/MemberContainer.vue'
import ShopcartContainer from './components/tabbars/ShopcartContainer.vue'
import SearchContainer from './components/tabbars/SearchContainer.vue'
import NewsList from './components/news/NewsList.vue'

const router = new VueRouter({
    routes: [
        { path: '/', redirect: '/home' },
        { path: '/home', component: HomeContainer },
        { path: '/member', component: MemberContainer },
        { path: '/shopcart', component: ShopcartContainer },
        { path: '/search', component: SearchContainer },
        { path: '/home/newslist', component: NewsList },
    ],
    linkActiveClass: 'mui-active'
})

export default router