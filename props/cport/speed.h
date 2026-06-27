#ifndef SPEED_H
#define SPEED_H

#include "myproperty.h"

typedef struct {
    MyProperty base;
} Speed;

Speed* speed_new(double value, const char* unit);

#endif
