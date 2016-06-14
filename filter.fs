module Filter
    
    let func filter list =
        match list with 
            | [] -> []
            | head::tail -> if (fun head = true) then head (filter func tail) else (filter func tail)
               
