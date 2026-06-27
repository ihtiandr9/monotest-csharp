#include "printer.h"
#include <stdio.h>

void printer_print(Printer* p, const char* s) {
    (void)p;
    printf("%s", s);
}

void printer_printline(Printer* p, const char* s) {
    (void)p;
    printf("%s\n", s);
}
