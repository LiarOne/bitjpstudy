function Person(name,age){
    //这里的name和age叫做实例属性（通过实例对象点出来的属性）
    this.name = name
    this.age = age
}
//原型方法
Person.prototype.showName = function(){
    console.log('我是：'+this.name)
}
//console.log(new Person('zs',22))

//这里的info叫做静态属性（使用构造函数点出来的属性）
Person.info = '这是function构造函数'
var p1 = new Person('zs',22)
//console.log(p1)
//console.log(Person.info)
//p1.showName()

//使用class定义的，叫做类
class Per {
    //constructor是构造函数
    //每当new Per()的时候，必然会优先调用Per上的constructor
    constructor(name,age){
        //console.log('ok')
        this.name = name
        this.age = age
    }
    //static是关键字，专门用来创建静态属性
    static info = '这是使用class关键字定义的类'
    //静态方法
    static show(){
        console.log('这是静态的show方法')
    }
    //实例方法
    showName(){
        console.log('我是：'+this.name)
    }
}
//console.log(new Per('ls',23))
var p2 = new Per('ls', 23)
console.log(p2.name) //实例属性（通过类的实例点出来的属性）
console.log(Per.info) //静态属性（通过类直接点出来的属性）
Per.show() //调用静态方法
p2.showName()