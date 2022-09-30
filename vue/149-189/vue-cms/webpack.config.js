const path = require('path')
const htmlWebpackPlugin = require('html-webpack-plugin') //导入插件
//const VueLoaderPlugin = require('vue-loader/lib/plugin')

module.exports = {
    mode: 'development',
    entry: path.join(__dirname, './src/main.js'), // 入口，表示，要使用 webpack 打包哪个文件
    output: { // 输出文件相关的配置
        path: path.join(__dirname, './dist'), // 指定 打包好的文件，输出到哪个目录中去
        filename: 'bundle.js' // 这是指定 输出的文件的名称
    },
    plugins:[ //插件的数组
        new htmlWebpackPlugin({ //创建一个把HTML首页托管到内存中的插件
            template:path.join(__dirname,'./src/index.html'), //把该html页面作为模板复制一份托管到内存中
            filename:'index.html' //指定在内存复制出的页面叫index.html
        }),
        //new VueLoaderPlugin()
    ],
    devServer:{ //webpack-dev-server运行时的指令
        // --open --port 3000 --host 127.0.0.1 --hot
        open: true, //自动打开浏览器
        port: 8080, //指定端口号
        host: '127.0.0.1',//指定IP地址
        hot: true //启用热更新
    },
    module: { //用来配置非JS文件对应loader
        rules: [
            { test: /\.css$/, use: ['style-loader','css-loader'] },
            { test: /\.less$/, use: ['style-loader','css-loader','less-loader'] },
            { test: /\.scss$/, use: ['style-loader','css-loader','sass-loader'] },
            //{ test: /\.jpg|png|gif|bmp$/, use: ['url-loader'] }  //limit表示图片大小，数值单位是byte，图片大小小于该值时，会被转为base64格式
            //{ test: /\.js$/, use: 'babel-loader', exclude:/node_modules/ }
            { test: /\.vue$/, use: 'vue-loader' } //解析vue组件的第三方loader
        ]
    },
    resolve: {
        // alias: {
        //     'vue$': 'vue/dist/vue.js'
        // }
    }
}