// Task4.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

int main()
{
    setlocale(LC_ALL, "Russian");
    int a, b, c;
    int avg;
    std::cout << "Введите три числа: ";
    std::cin >> a >> b >> c;

    __asm {
        mov eax, a
        add eax, b // a+b
        add eax, c // a+b+c
        mov edx, 0 // обнуление edx для корект.деления
        mov ecx, 3  //делитель
        div ecx // edx/ecx
        mov avg, eax
    }

    std::cout << "Среднее арифмет:  = " << avg << std::endl;
    return 0;



}


