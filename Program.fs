open System

Console.WriteLine("1111111")
Console.WriteLine()
let tuplefun(a: int, b: int, c: int) = a + b + c
let t1 = tuplefun(4,2,3)
Console.WriteLine("tuple function (4,2,3) : {0}", t1)

let curryfun a b c = a + b + c
let t2 = curryfun 1 2 3
Console.WriteLine("curry function 1 2 3 : {0}",t2)

Console.WriteLine("\n\n2222222")
Console.WriteLine()

let rec fib n = if n < 2 then 1 else fib (n - 1) + fib (n - 2)
let t3 = fib 5
Console.WriteLine("rec funcction fibonachi 5 : {0}",t3)

Console.WriteLine("\n\n3333333")
Console.WriteLine()

let rec fib_tr(n: int, prev: int, curr: int): int =
 if n < 2 then curr
 else fib_tr ((n - 1),curr,(curr+prev))
let t4 = fib_tr(5,1,1)

Console.WriteLine("rec tail funcction fibonachi 5 : {0}",t4)

Console.WriteLine("\n\n4444444")
Console.WriteLine()

let rec state1(x:int) = 
 Console.WriteLine("Нагрев льда t = {0}",(x+15))
 let x_next = x + 15
 if x_next = 0 then state2(x_next)
 else state1(x_next)
and state2(x:int) =
 Console.WriteLine("Таяние льда t = {0}",(x+1))
 let x_next = x + 1
 if x_next = 4 then state3(x_next)
 else state2(x_next)
and state3(x:int) =
 Console.WriteLine("Нагрев воды t = {0}",(x+24))
 let x_next = x + 24
 if x_next < 100 then state3(x_next)
 else if x_next = 100 then Console.WriteLine("Получился пар")

state1(-75)

Console.WriteLine("\n\n5555555")
Console.WriteLine()

let lambdatuple = fun (a: int, b: int, c: int) -> a + b + c
let lambdacurry = fun (a: int)(b: int)(c: int) -> a + b + c

let deltuple(a: int, b: int, c: int, func: int*int*int -> int) = func(a,b,c)
let deltuplecall = deltuple(1,2,3, lambdatuple)
Console.WriteLine("tuple del (1,2,3) : {0}", deltuplecall)

let delcurry(a: int, b: int, c: int, func1: int->int->int->int) = func1 a b c
let delcurrycall = delcurry(4,2,3, lambdacurry)
Console.WriteLine("curry del (4,2,3) : {0}", delcurrycall)