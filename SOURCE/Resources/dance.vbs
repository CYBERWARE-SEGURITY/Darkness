Set objShell = CreateObject("WMPlayer.OCX")
Set objMedia = objShell.newMedia(".\dance.mp3")
objShell.currentPlaylist.appendItem objMedia
objShell.controls.play

Do While objShell.playState <> 1
    WScript.Sleep 1000 
Loop