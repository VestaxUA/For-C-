#include <iostream>
using namespace std;

int main() {
	int R = 25;
	int a[5] = {-1, 8, -2, 6, 7};

	for (int i = 0; i < 5; i++) {
		if (a[i] % 2 == 0) {
			a[i] = R;
		}
	}
	for (int i = 0; i < 5; i++) {
		cout << a[i] << " ";
	}
}