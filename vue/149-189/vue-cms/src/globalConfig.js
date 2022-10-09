import Vue from 'vue'

import MintUI from 'mint-ui'
import 'mint-ui/lib/style.css'
Vue.use(MintUI)

import '../lib/mui/css/mui.min.css'
import '../lib/mui/css/icons-extra.css'

import './filters.js'

import VuePreview from 'vue-preview'
Vue.use(VuePreview)

import axios from 'axios'
Vue.prototype.$http = axios.create({
    baseURL: 'http://39.106.32.91:3000'
})