#include <iostream>
#include <cmath>

class Calculation{
    double c_x;
    double c_y;
    double c_z;
public:
    void setdata(int x,int y,int z){
        c_x = x;
        c_y = y;
        c_z = z;
    }
    double b(){
        return (pow(c_x, 2) + pow(c_z, 2) / pow(tan(pow(abs(c_x), 0.3)), 2)) /
               (3 + c_x + pow(c_y, 2) / 2 + pow(c_z, 3) / 6) +
               pow(log10(pow(c_y / c_z, 1. / 3)), 0.3);
    }
    double a(){
        return (2* cos(pow(abs(c_x), 1. / 3)) - pow(c_x, 2) / 6) /
               (c_z / b() + pow(sin(pow(c_y + c_z, 3)), 2)) +
               pow(log10(pow(abs(c_z), 0.6)), 2);
    }

};

int main() {
    double x, y = 0.47*5, z = -1.32*5;
    Calculation data;
    for(double i=-1;i<1;i+=0.2){
        data.setdata(i,y,z);
        std::cout << "Calculation b:" << data.b() << std::endl;
        std::cout << "Calculation a:" << data.a() << std::endl;
    }
}
