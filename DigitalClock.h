//
// Created by oleg on 9/17/23.
//

#ifndef UNTITLED1_DIGITALCLOCK_H
#define UNTITLED1_DIGITALCLOCK_H
#include "TimeController.h"
#include "DateController.h"


class DigitalClock {
public:
    TimeController time;
    DateController date;
    int hours_al, minutes_al, seconds_al;
public:
    DigitalClock();
    int startClock();
    void inputAlarm();
    std::tuple<int, int, int> inputTime();
    std::tuple<int, int, int> inputDate();
};


#endif //UNTITLED1_DIGITALCLOCK_H
