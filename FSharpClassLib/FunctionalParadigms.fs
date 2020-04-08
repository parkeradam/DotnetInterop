﻿namespace FSharpClassLib

module FunctionalParadigms =

    let aNumber = 5

    type Postcode = | Postcode of string

    type OtherLogLevels =
        | Error of int
        | Warning of struct(int * string)
        | Info of string

    type TypeOne = {
        Name: string
        agent: int
    }

    type TypeTwo = {
        isTrue : bool
        SomeNumber: double
    }

    type TypeThree =
        | TheOne of TypeOne
        | TheTwo of TypeTwo


    let stringConcat x y = 
        sprintf "%s %s" x y


    let getTypeTwoIfTrue (typeThree: TypeThree) =
        match typeThree with 
        | TheTwo x -> 
            Some x
        | _ -> None

    let parseInt x =
        match System.Int32.TryParse(x) with
        | success, result when success -> Some(result)
        | _ -> None

    let doAStringFunction stringFunc =
        stringFunc "Something"


module FuncParTwo =
    let add x y = x + y

    let message = "hello world";
