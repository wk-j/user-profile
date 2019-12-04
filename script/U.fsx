open System

Environment.SpecialFolder.ApplicationData
|> Environment.GetFolderPath
|> printfn "%s"

Environment.ExpandEnvironmentVariables("%ANDROID_HOME%")
|> printfn "%s"