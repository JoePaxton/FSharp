module Echo
  module Code =
    let name = "Joe Paxton"
    let min x y = if x < y then x else y
    let rec member element list =
      if list = [] then false
      else if element = (List.head list) then true
      else member element (List.tail list)
          
    let middleof3 (x,y,z) = y
    let makeOrigin x = (0,0)
    
    let headandneck list = (List.head, (List.head) List.tail)   
    
    let length rec list = 
      if list = [] then 0
      else list = 1 + length (List.tail)
      

  module Testing = 
    if (Code.min 5 -10) = -10 then printfn "min passed"
    if (Code.member 5 [1;2;3;4;5]) = true then printfn "member passed"
