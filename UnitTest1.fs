module mea_fsharp_training

open NUnit.Framework
open Swensen.Unquote


let euler1 upperBound = 
  let input = [1 .. (upperBound - 1)]
  let isMultipleOf a b = 
    a % b = 0
  let isMultipleOf3Or5 i = (isMultipleOf i 3) || (isMultipleOf i 5)
  let three569 : int list = List.filter isMultipleOf3Or5 input
  List.sum three569


[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    test <@ euler1 10 = 23 @>
