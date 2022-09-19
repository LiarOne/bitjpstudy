import $ from 'jquery'

//import mystyle from './css/index.css'
//webpack默认只能打包.js文件，如果想打包其他类型文件，需要配置合适的loader
//要处理css文件，需要配置style-loader和css-loader
import './css/index.css'
import './css/index.less'
import './css/index.scss'

$(function(){
    $('li:odd').css('backgroundColor','lightblue'),
    $('li:even').css('backgroundColor', 'pink')
})

/*class Person {
    static info = {name:'zs'}
}
console.log(Person.info)*/

//import m1 from './js/导入和导出.js'
//console.log(m1)

//import m2 from './js/class实现面向对象编程.js'