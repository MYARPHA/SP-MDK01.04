#include <iostream>

int main()
{
    setlocale(LC_ALL, "Russian");
    int n, result;
    std::cout << "Введите число: ";
    std::cin >> n;

    __asm {
        mov eax, n
        and eax, 1 //побитовая операция AND с 1 - 0 чётное, 1 - нечётное
        mov result, eax
    }

    if (result == 0)
    {
        std::cout << "Число чётное" << std::endl;
    }
    else 
    {
        std::cout << "Число нечётное" << std::endl;
    }
    
    return 0;



}


