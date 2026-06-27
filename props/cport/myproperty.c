#include "myproperty.h"
#include "printer.h"
#include <stdio.h>
#include <string.h>

static MyProperty* base_add(MyProperty* self, double d) {
    return myproperty_new(self->value + d, self->unit);
}

static MyProperty* base_sub(MyProperty* self, double d) {
    return base_add(self, -d);
}

static MyPropertyVtable base_vtable = { base_add, base_sub };

MyProperty* myproperty_new(double value, const char* unit) {
    MyProperty* p = (MyProperty*)GC_MALLOC(sizeof(MyProperty));
    p->vtable = &base_vtable;
    p->value = value;
    p->unit = unit ? GC_strdup(unit) : GC_strdup("");
    return p;
}

void myproperty_print(MyProperty* p, Printer* pr) {
    char* s = myproperty_tostring(p);
    printer_printline(pr, s);
}

MyProperty* myproperty_plus(MyProperty* p, double d) {
    return p->vtable->add(p, d);
}

MyProperty* myproperty_minus(MyProperty* p, double d) {
    return p->vtable->sub(p, d);
}

char* myproperty_tostring(MyProperty* p) {
    char buf[64];
    snprintf(buf, sizeof(buf), "%g %s", p->value, p->unit);
    return GC_strdup(buf);
}
