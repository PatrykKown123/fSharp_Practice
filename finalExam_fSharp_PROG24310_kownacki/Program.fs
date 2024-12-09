// For more information see https://aka.ms/fsharp-console-apps

let list = [2;3;4;1;5;6;-1;8;9]
let rec greatestNumber list = 
    let rec greatestNumber' list greatestNumber =
        match list with
        | [] -> greatestNumber
        | x::xs when x > greatestNumber -> greatestNumber' xs x
        | _::xs -> greatestNumber' xs greatestNumber
    greatestNumber' list 0

let smallestNumber list =
    let rec smallestNumber' list smallestNum =
        match list with
        | [] -> smallestNum
        | x::xs when x < smallestNum -> smallestNumber' xs x
        | _::xs -> smallestNumber' xs smallestNum
    smallestNumber' list (greatestNumber list)
    
printf "The smallest number of list is: %d" (smallestNumber list)
    