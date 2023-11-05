#include <iostream>
#include <cmath>

const double PI = 3.14159;

class Shape {
public:
    virtual double calculateArea() const = 0;
    virtual double calculatePerimeter() const = 0;
};

class Circle: public Shape {
private:
    double radius;
public:
    Circle(double rad): radius(rad) {}

    double calculateArea() const override {
        return PI * pow(radius, 2);
    }

    double calculatePerimeter() const override {
        return 2 * PI * radius;
    }
};

class Rectangle: public Shape {
private:
    double length;
    double width;
public:
    Rectangle(double len, double wid): length(len), width(wid) {}

    double calculateArea() const override {
        return length * width;
    }

    double calculatePerimeter() const override {
        return 2 * (length + width);
    }
};

class Triangle: public Shape {
private:
    double base;
    double height;
public:
    Triangle(double b, double h): base(b), height(h) {}

    double calculateArea() const override {
        return 0.5 * base * height;
    }

    double calculatePerimeter() const override {
        double hypotenuse = sqrt(pow(base, 2) + pow(height, 2));
        return base + height + hypotenuse;
    }
};

class Trapezoid: public Shape {
private:
    double base1;
    double base2;
    double side1;
    double side2;
    double height;
public:
    Trapezoid(double b1, double b2, double s1, double s2, double h): base1(b1), base2(b2), side1(s1), side2(s2), height(h) {}

    double calculateArea() const override {
        return 0.5 * (base1 + base2) * height;
    }

    double calculatePerimeter() const override{
        return base1 + base2 + side1 + side2;
    }
};

int main() {
    Circle c(5);
    Rectangle r(4, 6);
    Triangle t(3, 4);
    Trapezoid tp(10,20,7,8,5);

    std::cout << "Area of circle: " << c.calculateArea() << std::endl;
    std::cout << "Area of rectangle: " << r.calculateArea() << std::endl;
    std::cout << "Area of triangle: " << t.calculateArea() << std::endl;
    std::cout << "Area of trapezoid: " << tp.calculateArea() << std::endl;

    std::cout << "Perimeter of circle: " << c.calculatePerimeter() << std::endl;
    std::cout << "Perimeter of rectangle: " << r.calculatePerimeter() << std::endl;
    std::cout << "Perimeter of triangle: " << t.calculatePerimeter() << std::endl;
    std::cout << "Perimeter of trapezoid: " << tp.calculatePerimeter() << std::endl;

    return 0;
}