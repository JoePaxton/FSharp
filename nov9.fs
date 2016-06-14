//
// Nov 9 warmup coding
//

module Nov9
  module Code =
    let isOdd x = x % 2 = 1
    let isPositive x = x > 0
    let greet name = "Hello " + name

  module Testing =
    if not (Code.isOdd 3) then printfn "isOdd 3 failed"
    else printfn "isOdd 3 passed"
    if (Code.isOdd 8) then printfn "isOdd 8 failed"
    else printfn "isOdd 8 passed"

    if (Code.isPositive 3) then printfn "isPositive 3 passed"
    else printfn "isPositive 3 failed"
    if (Code.isPositive 0) then printfn "isPositive 0 failed"
    else printfn "isPositive 0 passed"
    if (Code.isPositive -8) then printfn "isPositive -8 failed"
    else printfn "isPositive -8 passed"

    if "Hello Jay" <> (Code.greet "Jay") then printfn "greet failed"
    else printfn "greet passed"
