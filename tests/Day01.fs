module Day01

open Xunit

[<Fact>]
let ``For a mass of 12 to get 2`` () =
    let result = Day01.FuelForSpaceModule 12
    Assert.Equal(2, result)
    
[<Fact>]
let ``For a mass of 14, the fuel required is also 2`` () =
    let result = Day01.FuelForSpaceModule 14
    Assert.Equal(2, result)

[<Fact>]
let ``For a mass of 1969, the fuel required is 654`` () =
    let result = Day01.FuelForSpaceModule 1969
    Assert.Equal(966, result)
    
[<Fact>]
let ``For a mass of 100756, the fuel required is 33583`` () =
    let result = Day01.FuelForSpaceModule 100756
    Assert.Equal(50346, result)