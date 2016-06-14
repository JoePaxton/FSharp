module Nov13
  module Code =
      let absofdiff a b = if a < b then b-a else a-b
      let rec isIn ele list =
          if list = [] then false
          else if ele = List.head list then true
               else isIn ele (List.tail list)
      let middleof3 (_,x,_) = x
               
