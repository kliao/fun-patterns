// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.


type Animal = Cat | Dog

let print e =
    match e with 
        | Cat -> printfn "meow"
        | Dog -> printfn "woof"

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let c = Cat
    let d = Dog

    print c
    print d

    System.Console.ReadKey() |> ignore

    0 // return an integer exit code




