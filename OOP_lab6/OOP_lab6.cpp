#include <iostream>
#include <locale>
#include <fstream>
#include <string>

template <typename T, std::size_t N>
T findMin(const T(&arr)[N]) {
    if (N == 0) {
        return T();
    }

    T minVal = arr[0];

    for (std::size_t i = 1; i < N; ++i) {
        if (arr[i] < minVal) {
            minVal = arr[i];
        }
    }

    return minVal;
}

template <typename T>
class TextFileEditor {
public:
    void removeStringFromPosition(const std::string& filename, int position, const T& strToRemove) {
        std::ifstream fileIn(filename);
        std::string content((std::istreambuf_iterator<char>(fileIn)), std::istreambuf_iterator<char>());
        fileIn.close();

        size_t found = content.find(strToRemove, position);
        if (found != std::string::npos) {
            content.erase(found, strToRemove.length());
        }

        std::ofstream fileOut(filename);
        fileOut << content;
        fileOut.close();
    }
};

int main() {
    setlocale(LC_ALL, "ukr");

    int intArray[] = { 5, 2, 8, 1, 6 };
    std::cout << "Мiнiмальне значення у масивi intArray: " << findMin(intArray) << std::endl;

    double doubleArray[] = { 3.14, 2.71, 1.618, 2.0, 3.0 };
    std::cout << "Мiнiмальне значення у масивi doubleArray: " << findMin(doubleArray) << std::endl;

    TextFileEditor<std::string> editor;
    editor.removeStringFromPosition("input.txt", 0, "Рядок на позиції");

    return 0;
}

