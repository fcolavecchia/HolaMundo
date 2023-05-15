// For more information see https://aka.ms/fsharp-console-apps
//printfn "Hello from F#"

// Entry Point 
// [<EntryPoint>]
// let main args = 
//     printfn $"Hola Mundo"
//     0

// 1. Agrego la biblioteca a este projecto con
// dotnet add reference ../../src/MyLibrary/MyLibrary.fsproj
// estando en el directorio de este proyecto.

// open MyLibrary
// o
// importo el modulo con
open MyLibrary.Say

// [<EntryPoint>]
// let main args = 
    
//     hello "Flavio"

//     //printfn $"Hola Mundo"

//     0

[<EntryPoint>]
let main args = 
    
    hello "Flavio"
    MyLibrary.Math.imprimeAdd 2 3 
    //printfn $"Hola Mundo"

    0