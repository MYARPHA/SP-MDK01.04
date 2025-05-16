#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    int a, b, min;

    cout << "Введите два числа: " << endl;
    cin >> a >> b;

    __asm {
        mov eax, a
        mov ebx, b
        cmp eax, ebx

        jg b_is_min
        mov eax, a
        mov min, eax
        jmp done
        
        b_is_min:
            mov eax, b
            mov min, eax

        done:
    }

    cout << "Минимум: " << min << endl;
    return 0;
}


