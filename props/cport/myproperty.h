#ifndef MYPROPERTY_H
#define MYPROPERTY_H

#include <gc.h>

typedef struct Printer Printer;

typedef struct MyProperty MyProperty;

typedef struct {
    MyProperty* (*add)(MyProperty* self, double d);
    MyProperty* (*sub)(MyProperty* self, double d);
} MyPropertyVtable;

struct MyProperty {
    MyPropertyVtable* vtable;
    double value;
    char* unit;
};

MyProperty* myproperty_new(double value, const char* unit);
void myproperty_print(MyProperty* p, Printer* pr);
MyProperty* myproperty_plus(MyProperty* p, double d);
MyProperty* myproperty_minus(MyProperty* p, double d);
char* myproperty_tostring(MyProperty* p);

#endif
