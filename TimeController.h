//
// Created by oleg on 9/17/23.
//

#ifndef UNTITLED1_TIMECONTROLLER_H
#define UNTITLED1_TIMECONTROLLER_H


class TimeController {
private:
    int seconds;
    int minutes;
    int hours;
public:
    TimeController();
    void setTime(int s, int m, int h);
    int getSeconds();
    int getMinutes();
    int getHours();
};


#endif //UNTITLED1_TIMECONTROLLER_H
