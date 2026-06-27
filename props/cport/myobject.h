#ifndef MYOBJECT_H
#define MYOBJECT_H

#include "speed.h"
#include "accel.h"
#include "printer.h"

typedef struct {
    Speed* speed;
    Accel* accel;
} MyObject;

MyObject* myobject_new(Speed* speed, Accel* accel);
void myobject_set_speed(MyObject* obj, Speed* speed);
char* myobject_tostring(MyObject* obj);
void myobject_print(MyObject* obj, Printer* p);

#endif
