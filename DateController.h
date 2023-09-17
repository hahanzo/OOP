//
// Created by oleg on 9/17/23.
//

#ifndef UNTITLED1_DATECONTROLLER_H
#define UNTITLED1_DATECONTROLLER_H


class DateController {
private:
    int day;
    int month;
    int year;
public:
    DateController();
    void setDate(int d, int m, int y);
    int getDay();
    int getMonth();
    int getYear();
};


#endif //UNTITLED1_DATECONTROLLER_H
