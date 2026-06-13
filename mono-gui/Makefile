TARGET = Program.exe
SRCS = Program.cs
REFERENCES = -r:System.Windows.Forms.dll -r:System.Drawing.dll
MCS = mcs

all: $(TARGET)

$(TARGET): $(SRCS)
	$(MCS) $(REFERENCES) $(SRCS)

run: $(TARGET)
	mono $(TARGET)

clean:
	rm -f $(TARGET)

.PHONY: all run clean
