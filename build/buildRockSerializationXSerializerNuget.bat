msbuild /p:Configuration=Release ..\Rock.Serialization.XSerializer\Rock.Serialization.XSerializer.csproj
nuget pack ..\Rock.Serialization.XSerializer\Rock.Serialization.XSerializer.csproj -Properties Configuration=Release