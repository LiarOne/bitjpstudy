import VueRouter from 'vue-router'

import HomeContainer from './components/tabbars/HomeContainer.vue'
import MemberContainer from './components/tabbars/MemberContainer.vue'
import ShopcartContainer from './components/tabbars/ShopcartContainer.vue'
import SearchContainer from './components/tabbars/SearchContainer.vue'
import NewsList from './components/news/NewsList.vue'
import NewsInfo from './components/news/NewsInfo.vue'
import PhotoList from './components/photos/PhotoList.vue'
import PhotoInfo from './components/photos/PhotoInfo.vue'
import GoodsList from './components/goods/GoodsList.vue'
import GoodsInfo from './components/goods/GoodsInfo.vue'
import GoodsDesc from './components/goods/GoodsDesc.vue'
import GoodsComment from './components/goods/GoodsComment.vue'

const router = new VueRouter({
    routes: [
        { path: '/', redirect: '/home' },
        { path: '/home', component: HomeContainer },
        { path: '/member', component: MemberContainer },
        { path: '/shopcart', component: ShopcartContainer },
        { path: '/search', component: SearchContainer },
        { path: '/home/newslist', component: NewsList },
        { path: '/home/newsinfo/:id', component: NewsInfo,props:true },
        { path: '/home/photolist', component: PhotoList },
        { path: '/home/photoinfo/:id', component: PhotoInfo, props:true },
        { path: '/home/goodslist', component: GoodsList },
        { path: '/home/goodsinfo/:id', component: GoodsInfo, props:true },
        { path: '/home/goodsdesc/:id', component: GoodsDesc, props:true },
        { path: '/home/goodscomment/:id', component: GoodsComment, props:true },
    ],
    linkActiveClass: 'mui-active'
})

export default router