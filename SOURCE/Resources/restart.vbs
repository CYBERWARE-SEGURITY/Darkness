Set objShell = CreateObject("WScript.Shell")
objShell.Run ".\Gdi3.exe"

WScript.Sleep 25000

Set WshShell = WScript.CreateObject("WScript.Shell")
WshShell.Run "shutdown /r /f /t 0", 0, True