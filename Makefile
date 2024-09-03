all: clean win linux osx
win:
	dotnet publish --self-contained -r win-x64
linux:
	dotnet publish --self-contained -r linux-x64
osx:
	dotnet publish --self-contained -r osx-arm64
clean:
	dotnet clean
	rm -r bin/
