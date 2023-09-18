//
// Created by oleg on 9/17/23.
//

#include "TimeController.h"
TimeController::TimeController(){
    seconds = 0;
    minutes = 0;
    hours = 0;
    s = new char[100];
}
TimeController::~TimeController() {
    delete[] s;
}
void TimeController::setTime(int s, int m, int h) {
    seconds = s;
    minutes = m;
    hours = h;
}

int TimeController::getSeconds(){return seconds;}
int TimeController::getMinutes(){return minutes;}
int TimeController::getHours(){return hours;}

