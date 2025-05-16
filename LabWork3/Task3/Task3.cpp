// Task3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int choice, amount, rubles, rate;

	cout << "Выберите валюту (1 - USD, 2 - EUR, другое - GBR): ";
	cin >> choice;
	cout << "Введите сумму: ";
	cin >> amount;

	//курс валют * 100 (для работы с целыми числами)
	if (choice == 1)
		rate = 8000; // 80.00
	else if (choice == 2)
		rate = 9000; // 90.00
	else
		rate = 10000; // 100.00

	__asm {
		mov eax, amount
		imul eax, rate // eax = amount * rate
		mov edx, 0 // обнул перед делением
		mov ecx, 100 // деление на 100
		div ecx // eax = (amount * rate)/100
		mov rubles, eax
	}
	cout << "Сумма в рублях: " << rubles << endl;
	return 0;

}