//
// Created by oleg on 9/17/23.
//

#include "DateController.h"

DateController::DateController() {
    day = 1;
    month = 1;
    year = 2023;
}

void DateController::setDate(int d, int m, int y) {
    day = d;
    month = m;
    year = y;
}

int DateController::getDay() {
    return day;
}

int DateController::getMonth() {
    return month;
}

int DateController::getYear() {
    return year;
}