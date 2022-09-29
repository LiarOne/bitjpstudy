import Vue from 'vue'


const login = {
    template:'<h3>这是Login组件</h3>'
}

const vm = new Vue({
    el:'#app',
    render: c=>c(login)
})