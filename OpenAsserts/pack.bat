set /p name=Which nuspec do you want to pack?
nuget pack %name% -Build -Symbols
pause
