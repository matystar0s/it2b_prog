@echo off
title NASA
chcp 65001 > nul
goto name

pause

:name
echo [38;2;255;255;0m                                               ▐ ▄  ▄▄▄· .▄▄ ·  ▄▄▄· 
echo                                               •█▌▐█▐█ ▀█ ▐█ ▀. ▐█ ▀█ 
echo                                               ▐█▐▐▌▄█▀▀█ ▄▀▀▀█▄▄█▀▀█ 
echo                                               ██▐█▌▐█ ▪▐▌▐█▄▪▐█▐█ ▪▐▌
echo                                               ▀▀ █▪ ▀  ▀  ▀▀▀▀  ▀  ▀ [0m [32m
powershell -Command $pword = read-host "Enter password" -AsSecureString ; ^
    $BSTR=[System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($pword) ; ^
        [System.Runtime.InteropServices.Marshal]::PtrToStringAuto($BSTR) > .tmp.txt 
set /p password=<.tmp.txt & del .tmp.txt

if /I %password% equ anime goto anime
echo Wrong Password

:y/n
echo.
echo Start hacking? y/n
set /p input=%BS%
if /I %input% equ y goto HACKING
if /I %input% equ n goto no
goto wrongin

:HACKING
echo.
timeout 1 > nul
echo HACKING NASA 10%%...
timeout 1 > nul
echo HACKING NASA 20%%...
timeout 1 > nul
echo HACKING NASA 30%%...
timeout 1 > nul
echo HACKING NASA 40%%...
timeout 1 > nul
echo HACKING NASA 50%%...
timeout 1 > nul
echo HACKING NASA 60%%...
timeout 1 > nul
echo HACKING NASA 70%%...
timeout 1 > nul
echo HACKING NASA 80%%...
timeout 1 > nul
echo HACKING NASA 90%%...
timeout 1 > nul
echo HACKING NASA 100%%
timeout 1 > nul
echo Loading.....[0m
timeout 3 > nul
cd C:\
goto banner


pause

:banner
echo.
echo.
echo [38;2;255;255;0m                   ▄▄▌ ▐ ▄▌▄▄▄ .▄▄▌   ▄▄·       • ▌ ▄ ·. ▄▄▄ .    ▄▄▄▄▄           ▐ ▄  ▄▄▄· .▄▄ ·  ▄▄▄· 
echo                    ██· █▌▐█▀▄.▀·██•  ▐█ ▌▪▪     ·██ ▐███▪▀▄.▀·    •██  ▪         •█▌▐█▐█ ▀█ ▐█ ▀. ▐█ ▀█ 
echo                    ██▪▐█▐▐▌▐▀▀▪▄██▪  ██ ▄▄ ▄█▀▄ ▐█ ▌▐▌▐█·▐▀▀▪▄     ▐█.▪ ▄█▀▄     ▐█▐▐▌▄█▀▀█ ▄▀▀▀█▄▄█▀▀█ 
echo                    ▐█▌██▐█▌▐█▄▄▌▐█▌▐▌▐███▌▐█▌.▐▌██ ██▌▐█▌▐█▄▄▌     ▐█▌·▐█▌.▐▌    ██▐█▌▐█ ▪▐▌▐█▄▪▐█▐█ ▪▐▌
echo                     ▀▀▀▀ ▀▪ ▀▀▀ .▀▀▀ ·▀▀▀  ▀█▄▀▪▀▀  █▪▀▀▀ ▀▀▀      ▀▀▀  ▀█▄▀▪    ▀▀ █▪ ▀  ▀  ▀▀▀▀  ▀  ▀    [0m     [32m                                                                                        
echo.
echo.
timeout 2 > nul
tree   
goto end

:no 
echo access denied                                                                                                       
pause
goto kill

:wrongin
echo.
echo.
echo Wrong input
echo Try again
goto y/n

:end
echo.
echo                      [38;2;255;255;0m     ╔╗╔╔═╗╔═╗╔═╗  ╦ ╦╔═╗╔═╗╦╔═╔═╗╔╦╗  ╔═╗╦ ╦╔═╗╔═╗╔═╗╔═╗╔═╗╦ ╦╦  ╦ ╦ ╦
echo                           ║║║╠═╣╚═╗╠═╣  ╠═╣╠═╣║  ╠╩╗║╣  ║║  ╚═╗║ ║║  ║  ║╣ ╚═╗╠╣ ║ ║║  ║ ╚╦╝
echo                           ╝╚╝╩ ╩╚═╝╩ ╩  ╩ ╩╩ ╩╚═╝╩ ╩╚═╝═╩╝  ╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚  ╚═╝╩═╝╩═╝╩ [0m [32m

pause
goto kill

:anime
echo yarinchin b club
echo boku no pico
echo redo od healer
echo highschool dxd

pause
goto kill
:kill

