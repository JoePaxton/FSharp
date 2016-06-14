//Author: Joe Paxton
//Chapter 4 (1-4)
module ch4
    module Code =
        let average list =
            let rec avgTR list sum count =
                match list with
                | [] -> (float(sum/count))
                | head::tail -> avgTR tail (sum+head) (count+1)
            avgTR list 0 0


        let rec exists func list = 
            match list with
            | [] -> false
            | head::tail -> if (func (head)) = true then true
                            else exists func tail
        
        let rec tryFind func list =
            match list with
            | [] -> None
            | head::tail -> if (func head) = true then Some head
                            else tryFind (func) (tail)


        let tryFindIndex func list =
            let rec tfiTR func list index =
                match list with
                | [] -> None
                | head::tail -> if (func head) = true then Some index
                                else tfiTR func tail (index+1)
            tfiTR func list 0


    module Testing =
        if(Code.average [10;20;30]) = 20.0 then printfn "Average for [10;20;30] passed!"
        printfn "average [10;10;10] is %A" (Code.average [10;10;10])
        printfn "average [1;1;1;97] is %A" (Code.average [1;1;1;97])
        
        printfn "exists (fun n -> n %% 5 = 0) [7..12] is %A" (Code.exists (fun n -> n % 5 = 0) [7..12])
        printfn "exists (fun n -> n %% 2 = 0) [7..12] is %A" (Code.exists (fun n -> n % 2 = 1) [7..12])
        
        printfn "tryFind (fun n -> n %% 2 = 0) [1..2..11] is %A" (Code.tryFind (fun n -> n % 2 = 0) [1..2..11])
        printfn "tryFind (fun n -> n %% 5 = 0) [2..8] is %A" (Code.tryFind (fun n -> n % 5 = 0) [2..8])

        printfn "tryFindIndex (fun n -> n %% 2 = 0) [1..2..11] is %A" (Code.tryFindIndex (fun n -> n % 2 = 0) [1..2..11])
        printfn "tryFindIndex (fun n -> n %% 5 = 0) [2..8] is %A" (Code.tryFindIndex (fun n -> n % 5 = 0) [2..8])


