
module Nov16

  //1. Identity function
  let identity x = x

  //2. makeOrigin
  let makeOrigin = (0,0)

  //3. head and neck of list as tuple
  // version 1 assumes list is big enough
  //  let headandneck list = ( (List.head list), (List.head (List.tail list)) )
  // version 2 does not assume length >= 2
  let headandneck list =
      if (List.length list) >= 2
      then
         Some( ( (List.head list), (List.head (List.tail list)) ) )
      else None
  // version 3 uses pattern matching construct
      let headandneck list =
          match list with
              | [] -> None
              | [x] -> None
              | head::neck::tail -> Sone ( (head,neck) )

  //4. recursive length
              let rec length list = if list = [] then 0 else 1 + length (List.tail list)
              // using pattern matching
              let rec length list =
                  match list with
                      | [] -> 0
                      | h::t -> 1 + length tail
  
  
