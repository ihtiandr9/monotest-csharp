BIN = hello.exe

all: ${BIN}

${BIN}: hello.cs
	mcs hello.cs
run: hello.exe
	mono hello.exe 1 2 3 
clean:
	rm -rf hello.exe