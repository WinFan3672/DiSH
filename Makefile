all: clean win linux osx
win:
	dotnet publish --self-contained -r win-x64 /p:PublishSingleFile=true
linux:
	dotnet publish --self-contained -r linux-x64 /p:PublishSingleFile=true
osx:
	dotnet publish --self-contained -r osx-arm64 /p:PublishSingleFile=true
clean:
	dotnet clean
	-rm -r bin/
