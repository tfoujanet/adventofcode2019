module Day01

let private generateFuelNeeds mass =
    let calculateFuelNeed = fun mass -> System.Math.Abs(mass / 3) - 2
    let initalFuelMass = calculateFuelNeed mass
    seq{
        let mutable remain = calculateFuelNeed initalFuelMass
        while remain>0 do
            yield remain
            remain <- calculateFuelNeed remain
        yield initalFuelMass
    }

let FuelForSpaceModule mass =
    mass |> generateFuelNeeds |> Seq.sum

let FuelForAllSpaceModules massList = 
    massList |> Seq.sumBy FuelForSpaceModule

let readData =
    System.IO.File.ReadAllLines("./data/day01.txt")

let launch () =
    readData
    |> Array.map System.Int32.Parse
    |> Array.toSeq
    |> FuelForAllSpaceModules