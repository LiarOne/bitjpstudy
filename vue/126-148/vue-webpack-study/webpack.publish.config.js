const path = require('path')
const htmlWebpackPlugin = require('html-webpack-plugin') //导入插件
const cleanPlugin = require('clean-webpack-plugin') //导入删除文件夹的插件
const webpack = require('webpack')
const extractTextPlugin = require('extract-text-webpack-plugin')
const optimizeCSSAssetsPlugin = require('optimize-css-assets-webpack-plugin')

module.exports = {
    entry: {
        app: path.join(__dirname, './src/main.js'), // 入口，表示，要使用 webpack 打包哪个文件
        vendors: ['jquery']//这是第三方包的名称
    },
    output: { // 输出文件相关的配置
        path: path.join(__dirname, './dist'), // 指定 打包好的文件，输出到哪个目录中去
        filename: 'bundle.js' // 这是指定 输出的文件的名称
    },
    plugins:[ //插件的数组
        new htmlWebpackPlugin({ //创建一个把HTML首页托管到内存中的插件
            template:path.join(__dirname,'./src/index.html'), //把该html页面作为模板复制一份托管到内存中
            filename:'index.html', //指定在内存复制出的页面叫index.html
            minify: { //压缩选项
                removeComments: true, //移除注释
                collapseWhitespace: true, //合并空白
                removeAttributeQuotes: true //移除属性节点上的引号
            }
        }),
        new cleanPlugin(['dist']), //指定每次重新发布时要先删除的文件夹
        new webpack.optimize.CommonsChunkPlugin({
            name:'vendors',
            filename: 'js/vendors.js' //指定抽离出来的第三方包，文件名叫什么
        }),
        new webpack.optimize.UglifyJsPlugin({
            compress: {
                warnings: false //压缩完毕的代码中移除警告信息
            }
        }),
        new webpack.DefinePlugin({ //此插件的作用相当于在项目的全局配置一些全局可用的变量，将来引用的第三方包中比如Vue会检查webpack有没有提供process.env.NODE_ENV字段，
            //如果有，并且字段名为production，就表示是生产发布环境，那么会移除不必要的Vue警告功能，并做其他优化
            'process.env.NODE_ENV':'"production"',
            //'myVar': '"1234"'
        }),
        new extractTextPlugin('css/styles.css'), //抽取css文件到单独的目录中
        new optimizeCSSAssetsPlugin() //自动压缩css
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
            { test: /\.css$/, use: extractTextPlugin.extract({
                fallback: 'style-loader',
                use: ['css-loader','less-loader'],
                publicPath: '../' //将来生成的样式中若包含路径，自动在路径前面加上该前缀
            }) },
            { test: /\.less$/, use: extractTextPlugin.extract({
                fallback: 'style-loader',
                use: ['css-loader','less-loader'],
                publicPath: '../'
            }) },
            { test: /\.scss$/, use: extractTextPlugin.extract({
                fallback: 'style-loader',
                use: ['css-loader','sass-loader'],
                publicPath: '../'
            }) },
            //{ test: /\.jpg|png|gif|bmp$/, use: ['url-loader'] }  //limit表示图片大小，数值单位是byte，图片大小小于该值时，会被转为base64格式
            //{ test: /\.js$/, use: 'babel-loader', exclude:/node_modules/ }
        ]
    }
}