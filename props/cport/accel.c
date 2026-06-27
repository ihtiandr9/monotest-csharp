#include "accel.h"
#include <string.h>

static MyProperty* accel_add(MyProperty* self, double d) {
    return &accel_new(self->value + d, self->unit)->base;
}

static MyProperty* accel_sub(MyProperty* self, double d) {
    return accel_add(self, -d);
}

static MyPropertyVtable accel_vtable = { accel_add, accel_sub };

Accel* accel_new(double value, const char* unit) {
    Accel* a = (Accel*)GC_MALLOC(sizeof(Accel));
    a->base.vtable = &accel_vtable;
    a->base.value = value;
    a->base.unit = unit ? GC_strdup(unit) : GC_strdup("m/s²");
    return a;
}
