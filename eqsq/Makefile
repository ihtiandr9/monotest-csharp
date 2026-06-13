BIN = hello.exe

all: ${BIN}

${BIN}: hello.cs equation.cs
	mcs hello.cs equation.cs
run: hello.exe
	mono hello.exe 1 2 3 
clean:
	rm -rf hello.exe
	
.PHONY: all
