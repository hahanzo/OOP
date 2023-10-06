#include <iostream>
#include <vector>

class Medicine{
private:
    std::string name;
    int quantity;
    double cost;

public:
    Medicine(std::string name, int quantity, double cost) : name(name), quantity(quantity), cost(cost) {
        if (quantity < 0 || cost < 0) {
            throw std::invalid_argument("Кількість та вартість не можуть бути від'ємними.");
        }
    }

    double TotalCost() const {
        return quantity * cost;
    }

    static double TotalCostForPrescription(const std::vector<Medicine>& prescription) {
        double totalCost = 0.0;
        for (const Medicine& medicine : prescription) {
            totalCost += medicine.TotalCost();
        }
        return totalCost;
    }

    static std::vector<Medicine> FindMedicine(const std::vector<Medicine>& prescription, std::string name) {
        std::vector<Medicine> find;
        for (const Medicine &medicine: prescription) {
            if (medicine.name == name) {
                find.push_back(medicine);
            }
        }
        return find;
    }

    static std::vector<Medicine> FindMedicine(const std::vector<Medicine>& prescription, double quantity) {
        std::vector<Medicine> find;
        for(const Medicine& medicine : prescription){
            if(medicine.quantity == quantity){
                find.push_back(medicine);
            }
        }
        return find;
    }

    static std::vector<Medicine> FindMedicine(const std::vector<Medicine>& prescription, int cost) {
        std::vector<Medicine> find;
        for(const Medicine& medicine : prescription){
            if(medicine.cost == cost){
                find.push_back(medicine);
            }
        }
        return find;
    }

    Medicine& operator+=(int amount) {
        if (amount < 0) {
            throw std::invalid_argument("Операнд не може бути відємним");
        }
        quantity += amount;
        return *this;
    }

    Medicine& operator-=(int amount) {
        if (amount < 0 && amount > quantity) {
            throw std::invalid_argument("Операнд не може бути відємним або перевищувати існуюче значення");
        }
        quantity -= amount;
        return *this;
    }

    Medicine& operator+(double amount) {
        if(amount < 0) {
            throw std::invalid_argument("Операнд не може бути відємним");
        }
        cost = cost + amount;
        return *this;
    }

    Medicine& operator-(double amount) {
        if(amount < 0 && amount > cost) {
            throw std::invalid_argument("Операнд не може бути відємним або перевищувати існуюче значення");
        }
        cost = cost - amount;
        return *this;
    }

    friend std::ostream& operator<<(std::ostream& out, const Medicine& medicine) {
        out << "Назва: " << medicine.name << std::endl;
        out << "Кількість: " << medicine.quantity << std::endl;
        out << "Вартість: " << medicine.cost << std::endl;
        return out;
    }
};



int main() {
    try {
        Medicine medicine("Парацетамол", 10, 23.59);
        std::cout << medicine << std::endl;

        medicine += 10;
        medicine + 10;

        std::cout << medicine << std::endl;

        medicine -= 5;
        medicine - 5;

        std::cout << medicine << std::endl;

        std::vector<Medicine> prescription;

        prescription.push_back(Medicine("Аспірин", 100, 2.5));
        prescription.push_back(Medicine("Парацетамол", 50, 3.0));
        prescription.push_back(Medicine("Ібупрофен", 50, 4.0));

        std::cout << "Загальна вартість ліків за рецептом: " << Medicine::TotalCostForPrescription(prescription) << std::endl;

        std::cout << "Всі ліки з кількістю 50:" << std::endl;
        std::vector<Medicine> find = Medicine::FindMedicine(prescription,50.0);

        for(const Medicine& medicine : find){
            std::cout << medicine << std::endl;
        }
    }
    catch (const std::invalid_argument& exepition) {
        std::cerr << "Помилка: " << exepition.what() << std::endl;
    }
    return 0;
}