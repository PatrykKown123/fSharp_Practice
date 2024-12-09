// For more information see https://aka.ms/fsharp-console-apps

let list = [2;3;4;1;-10;5;6;-1;8;9]

// greatestNumber retrieves the greatest number from the list
let rec greatestNumber list =
    // inner recursive function will return the greatest number
    let rec greatestNumber' list greatestNumber =
        match list with
        // when list is empty - return the greatest number
        | [] -> greatestNumber
        // when list head is greater than current greatestNumber - reassign greatestNumber
        | x::xs when x > greatestNumber -> greatestNumber' xs x
        // all other cases - pass the current greatest number
        | _::xs -> greatestNumber' xs greatestNumber
    // self call - beginning the check at 0
    greatestNumber' list 0

// works same as above but for small number
let smallestNumber list =
    let rec smallestNumber' list smallestNum =
        match list with
        | [] -> smallestNum
        | x::xs when x < smallestNum -> smallestNumber' xs x
        | _::xs -> smallestNumber' xs smallestNum
        // passes a function to begin count from the greatest number
    smallestNumber' list (greatestNumber list)
    
printf "The smallest number of list is: %d" (smallestNumber list)
    