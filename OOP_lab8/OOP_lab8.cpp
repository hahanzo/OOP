#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>

using namespace std;

int main() {

    setlocale(LC_ALL, "ukr");

    int n;
    cout << "����i�� ����i� ������: ";
    cin >> n;

    vector<int> arr(n);
    cout << "����i�� �������� ������: ";
    for (int i = 0; i < n; ++i) {
        cin >> arr[i];
    }

    int maxElement = *max_element(arr.begin(), arr.end());
    cout << "������������ ������� ������: " << maxElement << endl;

    auto lastPositive = find_if(arr.rbegin(), arr.rend(), [](int x) { return x > 0; });
    int sumBeforeLastPositive = accumulate(arr.begin(), lastPositive.base(), 0);
    cout << "���� �������i� �� ���������� ���������� ��������: " << sumBeforeLastPositive << endl;

    int a, b;
    cout << "����i�� i������� [a, b]: ";
    cin >> a >> b;

    arr.erase(remove_if(arr.begin(), arr.end(), [a, b](int x) { return abs(x) >= a && abs(x) <= b; }), arr.end());

    arr.resize(n, 0);

    cout << "��������� �����: ";
    for (int i : arr) {
        cout << i << " ";
    }

    return 0;
}
