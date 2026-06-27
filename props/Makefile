BIN  = myobjtest.exe
SRCS = program.cs printer.cs myobject.cs speed.cs accel.cs myproperty.cs

.PHONY: all clean run

all: ${BIN}

${BIN}: ${SRCS}
	mcs -out:$@ ${SRCS}

run: ${BIN}
	mono ${BIN}

clean:
	rm -f ${BIN}
