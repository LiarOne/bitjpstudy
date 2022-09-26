class Person{
    constructor(name,age){
        this.name = name
        this.age = age
    }
    sayHello(){
        console.log('我的名字是：' + this.name)
    }
}

class GDRen extends Person{
    constructor(name,age,eathobby){
        // super() //引申为父类的构造函数，如果子类通过extends实现继承，子类构造函数中必须先调用super()才能使用this
        // this.name = name
        // this.age = age
        super(name,age)
        this.eathobby = eathobby
    }
}

//var p1 = new Person('高婆婆',26)
//console.log(p1)

var gd1 = new GDRen('xj','18','fjr')
//console.log(gd1)
gd1.sayHello()