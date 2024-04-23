# FF GUI (Avalonia UI)

GUI for the [FFcollection](https://github.com/TcPirate1/FFTCG_collection).

Margin/Padding (left, top, right, bottom).

Designing and modifying UI. [Alignment, Padding & Margins](https://docs.avaloniaui.net/docs/basics/user-interface/building-layouts/alignment-margins-and-padding) and [Panel Overview](https://docs.avaloniaui.net/docs/basics/user-interface/building-layouts/panels-overview)

## Build

Ensure you have a `.NET SDK` installed and run `dotnet run` in the project directory.

If using `VSCode`, the extension requires [.NET 8.0 core](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.vscode-avalonia) to use previewer and code completion. However if you're not worried about either then just a `.NET SDK` is required.

## TODO

[x] Fixed download error by running the install script myself so that it wouldn't face permission errors. This doesn't fix that the settings does not use the specified path.

[x] C# dev kit does not detect the installed .NET sdk on Manjaro machine. Update: If it is opened through file context menu the error will occur but if opened through Terminal Emulator then it will not.

[x] Cancel button functionality. Instead of closing the page, it will just clear text fields.

[] Connect to MongoDB (Need to convert to a web service at a later date).

[] Read, Add, Edit, Delete (in this order).

## Pages

![Home Page](./ProgressImages/Avalonia_FFGUI_HomePage.png)
![Add Page](./ProgressImages/Avalonia_FFGUI_AddPage.png)
![Search Page](./ProgressImages/Avalonia_FFGUI_SearchPage.png)
