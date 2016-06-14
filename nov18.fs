
module Nov18

// doubleEach function
// [1;3;5] -> [2;6;10]

let rec doubleEach list =
    match list with
        | [] -> []
        | head::tail -> (head*2) :: (doubleEach tail)

// onEach function
// [1;3;5] -> [1;9;25]

let rec onEach func list =
    match list with
        | [] -> []
        | head::tail -> (func head) :: (onEach func tail)
