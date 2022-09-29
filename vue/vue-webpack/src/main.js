import Vue from 'vue'


// const login = {
//     template:'<h3>这是Login组件</h3>'
// }

import app from './components/App.vue'

const vm = new Vue({
    el:'#app',
    render: c=>c(app)
})