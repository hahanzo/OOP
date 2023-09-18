//
// Created by oleg on 9/17/23.
//
#include <iostream>
#include <cstdlib>
#include <chrono>
#include <thread>
#include <tuple>
#include "DigitalClock.h"

DigitalClock::DigitalClock() {
    DateController date;
    TimeController time;
    int hours_al, minutes_al, seconds_al;
    s = new char[100];
}

DigitalClock::~DigitalClock() {
    delete[] s;
}

void DigitalClock::inputAlarm() {

    std::cout << "Input hours alarm: ";
    std::cin >> hours_al;

    std::cout << "Input minutes alarm: ";
    std::cin >> minutes_al;

    std::cout << "Input seconds alarm: ";
    std::cin >> seconds_al;
}

std::tuple<int, int, int> DigitalClock::inputTime() {
    int hours, minutes, seconds;

    std::cout << "Input hours: ";
    std::cin >> hours;

    std::cout << "Input minutes: ";
    std::cin >> minutes;

    std::cout << "Input seconds: ";
    std::cin >> seconds;

    return std::make_tuple(hours, minutes, seconds);
}

std::tuple<int, int, int> DigitalClock::inputDate() {
    int day, month, year;

    std::cout << "Input year: ";
    std::cin >> year;

    std::cout << "Input month: ";
    std::cin >> month;

    std::cout << "Input day: ";
    std::cin >> day;

    return std::make_tuple(day, month, year);
}

int DigitalClock::startClock() {
    int hrs = time.getHours();
    int minutes = time.getMinutes();
    int seconds = time.getSeconds();
    int day = date.getDay();
    int month = date.getMonth();
    int year = date.getYear();
    while (hours_al!=hrs || minutes_al!=minutes || seconds_al!=seconds){
        if (system("clear")) system( "cls" );

        std::cout << "The time is :";
        std::cout << "      |" << hrs << " : " << minutes << " : " << seconds << " " << std::endl;
        std::cout << "The date is :";
        std::cout << "      |" << day << " / " << month << " / " << year << " " << std::endl;

        seconds++;
        if (seconds >= 60)
        {
            seconds = 1;
            minutes++;
        }
        // This increases the minutes
        if (minutes >= 60)
        {
            minutes = 0;
            hrs++;
        }
        // This increases the hours
        if (hrs > 24)
        {
            hrs = 00;
        }
        std::this_thread::sleep_for(std::chrono::milliseconds(1000));
    }
    if (system("clear")) system( "cls" );
    for (int i = 0; i < 10; ++i) {
        std::cout << "it's time to get up to work" << std::endl;
        std::this_thread::sleep_for(std::chrono::milliseconds(1000));
    }
}

