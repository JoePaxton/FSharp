module Nov11
  let name = "Jbf"
  let min a b = if a < b  then a else b
  // FSharp doesn't like "member" as a name
  let rec mymember element list = 
    if list = [] then false
    else if element = (List.head list) 
         then true 
         else mymember element (List.tail list)
