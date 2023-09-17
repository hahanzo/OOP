#include <iostream>
#include <tuple>
#include "DigitalClock.h"

int main() {
    DigitalClock clock1;
    int hours, minutes, seconds,day, month, year;

    std::tie(hours, minutes, seconds) = clock1.inputTime();
    clock1.time.setTime(seconds, minutes, hours);

    std::tie(day, month, year) = clock1.inputDate();
    clock1.date.setDate(day, month, year);

    clock1.inputAlarm();
    clock1.startClock();

    return 0;
}