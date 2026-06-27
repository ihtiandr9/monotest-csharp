#ifndef ACCEL_H
#define ACCEL_H

#include "myproperty.h"

typedef struct {
    MyProperty base;
} Accel;

Accel* accel_new(double value, const char* unit);

#endif
