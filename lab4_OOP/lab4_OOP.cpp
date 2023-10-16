#include <iostream>
#include <fstream>
using namespace std;

class Computer {
protected:
    string model;
    double price;

public:
    Computer(const string& model, double price) : model(model), price(price) {}

    virtual void printInfo() {
        cout << "������: " << model << ", ֳ��: " << price << " ���" << endl;
    }

    string getModel() const {
        return model;
    }

    double getPrice() const {
        return price;
    }
};

class Processor : public Computer {
private:
    string brand;
    double clockSpeed;

public:
    Processor(const string& model, double price, const string& brand, double clockSpeed)
        : Computer(model, price), brand(brand), clockSpeed(clockSpeed) {}

    void printInfo() override {
        cout << "������: " << model << ", ֳ��: " << price << " ���, �����: " << brand << ", ������� �������: " << clockSpeed << " ���" << endl;
    }

    string getBrand() const {
        return brand;
    }

    double getClockSpeed() const {
        return clockSpeed;
    }
};

class HardDisk : public Computer {
private:
    double capacity;

public:
    HardDisk(const string& model, double price, double capacity)
        : Computer(model, price), capacity(capacity) {}

    void printInfo() override {
        cout << "������: " << model << ", ֳ��: " << price << " ���, �����: " << capacity << " �����" << endl;
    }

    double getCapacity() const {
        return capacity;
    }
};

int main() {
    Processor processor("Intel i7", 1000.0, "Intel", 3.5);
    HardDisk hardDisk("WD Blue", 200.0, 1000.0);

    cout << "���������� ��� ��������:" << endl;
    processor.printInfo();

    cout << "���������� ��� �������� ����:" << endl;
    hardDisk.printInfo();

    ofstream outFile("computer_info.txt");
    if (outFile.is_open()) {
        outFile << "���������� ��� ��������:" << endl;
        outFile << "������: " << processor.getModel() << ", ֳ��: " << processor.getPrice() << " ���, �����: " << processor.getBrand() << ", ������� �������: " << processor.getClockSpeed() << " ���" << endl;

        outFile << "���������� ��� �������� ����:" << endl;
        outFile << "������: " << hardDisk.getModel() << ", ֳ��: " << hardDisk.getPrice() << " ���, �����: " << hardDisk.getCapacity() << " �����" << endl;

        outFile.close();
        cout << "���������� �������� � ���� computer_info.txt" << endl;
    }
    else {
        cout << "������� �������� �����!" << endl;
    }

    return 0;
}
