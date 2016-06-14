module removefirst

let rec rmfst elem fst = 
    match fst with
    | [] -> fst
    | head::tail -> head::rmfst elem tail
