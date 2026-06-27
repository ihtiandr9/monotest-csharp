#include "myobject.h"
#include <stdio.h>
#include <string.h>

MyObject* myobject_new(Speed* speed, Accel* accel) {
    MyObject* obj = (MyObject*)GC_MALLOC(sizeof(MyObject));
    obj->speed = speed;
    obj->accel = accel;
    return obj;
}

void myobject_set_speed(MyObject* obj, Speed* speed) {
    obj->speed = speed;
}

char* myobject_tostring(MyObject* obj) {
    char* spd = myproperty_tostring(&obj->speed->base);
    char* acc = myproperty_tostring(&obj->accel->base);
    char buf[128];
    snprintf(buf, sizeof(buf), "MyObject [Speed: %s, Accel: %s]", spd, acc);
    return GC_strdup(buf);
}

void myobject_print(MyObject* obj, Printer* p) {
    printer_printline(p, "Hello from CPort");
    char* s = myobject_tostring(obj);
    printer_printline(p, s);
    printer_print(p, "Speed: ");
    myproperty_print(&obj->speed->base, p);
    printer_print(p, "Accel: ");
    myproperty_print(&obj->accel->base, p);
}
