#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    int num, isEven;

    cout << "Введите число: ";
    cin >> num;
    
    __asm {
        mov eax, num
        cdq // для idiv
        mov ecx, 2 // деление на 2
        idiv ecx // eax = num / 2, edx = num % 2(ост)

        cmp edx, 0 // если остаток 0 - чётное
        jne odd // если != то нечёт (переход если операнды не равны)

        mov isEven, 1 // чётное
        jmp done

        odd:
            mov isEven, 0 // нечётное

        done:
    }
    cout << "Чётное? (1 - да, 0 - нет): " << "Число " << num << ": " << isEven << endl;
    return 0;
}

