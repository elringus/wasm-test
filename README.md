To compile C# into WebAssemly and interop with JavaScript it's required to use Blazor WebAssembly ASP.NET framework, which is designed for SPA and contains lot of overhead in case you just want to use a C# library from JS.

This example shows the minimum setup required for the use case.

The key files to check for:

 - [Project configuration (.csproj)](https://github.com/Elringus/WasmTest/blob/main/WasmTest.csproj)
 - [C# bindings](https://github.com/Elringus/WasmTest/blob/main/Program.cs)
 - [JS bindings](https://github.com/Elringus/WasmTest/blob/main/wwwroot/index.html)
