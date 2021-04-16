// EasyCalculation.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

bool blSprawWartosc(char strText, int intWartosc)
{
    bool blWartosc = false;
    int input = 0;

    switch (strText)
    {
        case 'a':
            if (intWartosc > 0 && intWartosc < 100000)
            {
                blWartosc = true;
            }
            else
            {
                while (intWartosc > 100000)
                {
                    std::cout << "Prosze podac poprawna liczba" << std::endl;
                    std::cin >> input;
                    blWartosc = blSprawWartosc('t', input);
                }
            }
            break;

        case 'b':
            if (intWartosc > 0 && intWartosc < 100000)
            {
                blWartosc = true;
            }
            else
            {
                while (intWartosc > 100000)
                {
                    std::cout << "Prosze podac poprawna liczba" << std::endl;
                    std::cin >> input;
                    blWartosc = blSprawWartosc('t', input);
                }
            }
            break;

        case 'c':
            if (intWartosc > 0 && intWartosc < 100000)
            {
                blWartosc = true;
            }
            else
            {
                while (intWartosc > 100000)
                {
                    std::cout << "Prosze podac poprawna liczba" << std::endl;
                    std::cin >> input;
                    blWartosc = blSprawWartosc('t', input);
                }
            }
            break;

        case 't':
            if (intWartosc > 0 && intWartosc < 6)
            {
                blWartosc = true;
            }
            else
            {
                while (intWartosc > 6)
                {
                    std::cout << "Prosze podac poprawna liczba" << std::endl;
                    std::cin >> input;
                    blWartosc = blSprawWartosc('t', input);
                }
            }
            break;

    }

    return blWartosc;
}

int main()
{
    int t, a, b, c, input = 0;
    bool wartosc = false;
    
    std::cout << "Prosze podac testcasow: ";
    std::cin >> input;

    if (wartosc = blSprawWartosc('t', input))
    {
        t = input;
    }

    char zmienne[] = { 'a', 'b', 'c' };
    char teks[3];

    for (int indeks = t; indeks > 0; indeks--)
    {
        std::cin.getline(teks, 3);
        for (int indeks2 = 0; indeks2 < sizeof(zmienne); indeks2++)
        {
            if (blSprawWartosc(zmienne[indeks2], teks[indeks2]))
                continue;
            
        }
    }

}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
