#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>

using namespace std;

int main() {

    setlocale(LC_ALL, "ukr");

    int n;
    cout << "Введiть розмiр масиву: ";
    cin >> n;

    vector<int> arr(n);
    cout << "Введiть елементи масиву: ";
    for (int i = 0; i < n; ++i) {
        cin >> arr[i];
    }

    int maxElement = *max_element(arr.begin(), arr.end());
    cout << "Максимальний елемент масиву: " << maxElement << endl;

    auto lastPositive = find_if(arr.rbegin(), arr.rend(), [](int x) { return x > 0; });
    int sumBeforeLastPositive = accumulate(arr.begin(), lastPositive.base(), 0);
    cout << "Сума елементiв до останнього додатнього елемента: " << sumBeforeLastPositive << endl;

    int a, b;
    cout << "Введiть iнтервал [a, b]: ";
    cin >> a >> b;

    arr.erase(remove_if(arr.begin(), arr.end(), [a, b](int x) { return abs(x) >= a && abs(x) <= b; }), arr.end());

    arr.resize(n, 0);

    cout << "Оновлений масив: ";
    for (int i : arr) {
        cout << i << " ";
    }

    return 0;
}
