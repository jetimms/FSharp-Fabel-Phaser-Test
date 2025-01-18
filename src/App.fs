module App

open Browser.Dom
open Fable.Core
open Fable.Core.JsInterop
open Globals
open GameScene

let jsOptions<'T> (f: 'T -> unit): 'T =
    let obj = createObj [] :?> 'T
    f obj
    obj

let Phaser = importAll<obj> "phaser"

let config =
    jsOptions<obj> (fun opts ->
            opts?``type`` <- Phaser?``AUTO``
            opts?width <- 800
            opts?height <- 600
            opts?scene <- createScene ()
    )

let main () =
    let game = Phaser?Game(config)
    game

main ()
