#ifndef PRINTER_H
#define PRINTER_H

typedef struct Printer Printer;
struct Printer { };

void printer_print(Printer* p, const char* s);
void printer_printline(Printer* p, const char* s);

#endif
