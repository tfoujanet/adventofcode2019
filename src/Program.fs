// Learn more about F# at http://fsharp.org

open System

let formatterDay01 () =
    Day01.launch().ToString()

let formatterDay02 () =
    let mapToString = fun m -> m.ToString()
    let stringValues = Day02.RunProgram()
                       |> Array.map mapToString
    String.Join(',', stringValues)

[<EntryPoint>]
let main argv =
    let mapToString = fun m -> m.ToString()
    match argv.[0] with
    |"d1" -> formatterDay01() |> Console.WriteLine
    |"d2" ->  formatterDay02() |> Console.WriteLine 
    //|"d2" -> Day02Program argv.[1]
    //|"d4.1" -> (HowManyDifferentPasswordsPart1 264793 803935).ToString()
    //|"d4.2" -> (HowManyDifferentPasswordsPart2 264793 803935).ToString()
    |_ -> Console.WriteLine("ok")
    0 // return an integer exit code
