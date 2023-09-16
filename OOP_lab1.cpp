#include <iostream>
#include <cmath>

class Calculation{
    double m_x;
    double m_y;
    double m_z;
public:
    void setdata(int x,int y,int z){
        m_x = x;
        m_y = y;
        m_z = z;
    }
    double b(){
        return (pow(m_x, 2) + pow(m_z, 2) / pow(tan(pow(abs(m_x), 0.3)), 2)) /
               (3 + m_x + pow(m_y, 2) / 2 + pow(m_z, 3) / 6) +
               pow(log10(pow(m_y / m_z, 1. / 3)), 0.3);
    }
    double a(){
        return (2* cos(pow(abs(m_x), 1. / 3)) - pow(m_x, 2) / 6) /
        (m_z / b() + pow(sin(pow(m_y + m_z, 3)), 2)) +
        pow(log10(pow(abs(m_z), 0.6)), 2);
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
