import Vue from 'vue'
import moment from 'moment'

Vue.filter('dateFormat',function(dataStr){
    return moment(dataStr).format('YYYY-MM-DD HH:mm:ss')
})