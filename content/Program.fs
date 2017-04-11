module Program

open KestrelInterop

[<EntryPoint>]
let main argv =
  let configureApp =
    ApplicationBuilder.useFreya Api.root

  WebHost.create ()
  |> WebHost.bindTo [|"http://localhost:5000"|]
  |> WebHost.configure configureApp
  |> WebHost.buildAndRun

  0 // return an integer exit code
