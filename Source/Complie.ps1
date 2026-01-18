$Env:Path += ";C:\Windows\Microsoft.NET\Framework64\v4.0.30319"
csc /target:winexe /win32icon:UninstallEdge.ico /win32manifest:app.manifest UninstallEdge.cs
