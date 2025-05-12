#include <iostream>

int main()
{
    setlocale(LC_ALL, "Russian");
    int a, b;
    std::cout << "Введите два числа: ";
    std::cin >> a >> b;

    __asm {
        mov eax, a // А в eax
        mov ebx, b //B в ebx

        xor eax, ebx // eax = a^b
        xor ebx, eax // b^(a^b) = a
        xor eax, ebx

        mov a, eax
        mov b, ebx
    }
    std::cout << "После обмена a = " << a << ", b = " << b << std::endl;
    return 0;
    
}
