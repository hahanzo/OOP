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
        cout << "Модель: " << model << ", Ціна: " << price << " грн" << endl;
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
        cout << "Модель: " << model << ", Ціна: " << price << " грн, Бренд: " << brand << ", Тактова частота: " << clockSpeed << " ГГц" << endl;
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
        cout << "Модель: " << model << ", Ціна: " << price << " грн, Обсяг: " << capacity << " Гбайт" << endl;
    }

    double getCapacity() const {
        return capacity;
    }
};

int main() {
    Processor processor("Intel i7", 1000.0, "Intel", 3.5);
    HardDisk hardDisk("WD Blue", 200.0, 1000.0);

    cout << "Інформація про процесор:" << endl;
    processor.printInfo();

    cout << "Інформація про жорсткий диск:" << endl;
    hardDisk.printInfo();

    ofstream outFile("computer_info.txt");
    if (outFile.is_open()) {
        outFile << "Інформація про процесор:" << endl;
        outFile << "Модель: " << processor.getModel() << ", Ціна: " << processor.getPrice() << " грн, Бренд: " << processor.getBrand() << ", Тактова частота: " << processor.getClockSpeed() << " ГГц" << endl;

        outFile << "Інформація про жорсткий диск:" << endl;
        outFile << "Модель: " << hardDisk.getModel() << ", Ціна: " << hardDisk.getPrice() << " грн, Обсяг: " << hardDisk.getCapacity() << " Гбайт" << endl;

        outFile.close();
        cout << "Інформація записана в файл computer_info.txt" << endl;
    }
    else {
        cout << "Помилка відкриття файлу!" << endl;
    }

    return 0;
}
