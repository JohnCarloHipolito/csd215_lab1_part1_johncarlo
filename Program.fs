// this code will add all even numbers from a list
let evenNumber num = num % 2 = 0

let rec sumOfEvenNumbersTail intList sum =
    match intList with
    | [] -> sum
    | head :: tail -> sumOfEvenNumbersTail tail (if evenNumber head then sum + head else sum)

let sumOfEvenNumbers intList = sumOfEvenNumbersTail intList 0

// main program
let intList = [ 1..10 ]
printfn $"The sum of all even numbers from list %A{intList} is %d{sumOfEvenNumbers intList}"
