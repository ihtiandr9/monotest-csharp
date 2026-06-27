#include "speed.h"
#include <string.h>

static MyProperty* speed_add(MyProperty* self, double d) {
    return &speed_new(self->value + d, self->unit)->base;
}

static MyProperty* speed_sub(MyProperty* self, double d) {
    return speed_add(self, -d);
}

static MyPropertyVtable speed_vtable = { speed_add, speed_sub };

Speed* speed_new(double value, const char* unit) {
    Speed* s = (Speed*)GC_MALLOC(sizeof(Speed));
    s->base.vtable = &speed_vtable;
    s->base.value = value;
    s->base.unit = unit ? GC_strdup(unit) : GC_strdup("m/s");
    return s;
}
