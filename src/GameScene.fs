module GameScene

open Browser.Dom
open Fable.Core
open Fable.Core.JsInterop
open Globals

let preload (): unit =
    // Load assets here
    if debug then console.log("Preload")

let create () =
    // Initialize game objects here
    if debug then console.log("Create")

let update () =
    // Game logic here
    if debug then console.log("Update")

let createScene () = 
    jsOptions<obj> (fun scene ->
        scene?preload <- preload
        scene?create <- create
        scene?update <- update
    )
