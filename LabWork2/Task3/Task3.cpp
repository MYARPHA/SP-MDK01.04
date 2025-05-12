// Task3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

int main()
{   
    setlocale(LC_ALL, "Russian");
    int a, b, c, d, z;
    std::cout << "Введите A, B, C, D: ";
    std::cin >> a >> b >> c >> d;
    
    __asm {
        mov eax, a
        add eax, b // eax = a+b
        mov ebx, c
        add ebx, d // ebx = c+d
        sub eax, ebx // eax = (a+b) - (c+d)
        mov z, eax
    }
    //z = (a + b) - (c + d);
    std::cout << "Z = " << z << std::endl;
    return 0;
}