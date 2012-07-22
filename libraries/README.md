#Compilation instructions

gmcs -t:library wingmaker.cs
gmcs program.cs -r:wingmaker.dll
