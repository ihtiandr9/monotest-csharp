#include <gc.h>
#include "myobject.h"

int main() {
    GC_INIT();

    Speed* speed = speed_new(100, "km/h");
    Accel* accel = accel_new(9.8, NULL);
    MyObject* obj = myobject_new(speed, accel);

    Printer printer;
    myobject_print(obj, &printer);

    printer_printline(&printer, "\nAfter 2s acceleration:");

    speed  = (Speed* )myproperty_plus(&obj->speed->base, 2 * obj->accel->base.value);
    myobject_set_speed(obj, speed);

    myobject_print(obj, &printer);
    
    printer_printline(&printer, "\nAfter 3s deceleration:");

    speed = (Speed* )myproperty_minus(&obj->speed->base, 3 * obj->accel->base.value);
    myobject_set_speed(obj, speed);

    myobject_print(obj, &printer);

    return 0;
}
