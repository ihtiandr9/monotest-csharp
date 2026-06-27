CC = gcc
CFLAGS = -Wall -Wextra -g
LDFLAGS = -lgc
BIN = cport
SRCS = main.c myproperty.c speed.c accel.c printer.c myobject.c
OBJS = $(SRCS:.c=.o)

.PHONY: all clean run

all: $(BIN)

$(BIN): $(OBJS)
	$(CC) $(CFLAGS) -o $@ $^ $(LDFLAGS)

%.o: %.c
	$(CC) $(CFLAGS) -c -o $@ $<

run: $(BIN)
	./$(BIN)

clean:
	rm -f $(BIN) $(OBJS)
