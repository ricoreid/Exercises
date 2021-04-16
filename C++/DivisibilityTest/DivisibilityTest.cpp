// DivisibilityTest.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <math.h>

int main()
{
    // declaracji - kazdy zmienne
    int p0, p1, n, q, t, intWartosc, Pi = 0;

    // poprosic o ilosc testcas¢w
    std::cout << "Prosze podac ilosci testcasow beda? ";
    std::cout << std::endl;
    std::cin >> t;
    std::string strWartosc;
    
    // p“tli zeby dostaá testcas¢w
    for (int index = 0; index < t; index++)
    {
        std::cout << "Prosze podac pierwsza wartosc: ";
        std::cout << std::endl;
        std::cin >> p0;
        std::cout << "Prosze podac druga wartosc: ";
        std::cout << std::endl;
        std::cin >> p1;
        std::cout << "Prosze podac wartosc do podzielenia: ";
        std::cout << std::endl;
        std::cin >> q;
        std::cout << "Prosze podac dlugosc wartosc:: ";
        std::cout << std::endl;
        std::cin >> n;

        if (n = 1)
        {
            intWartosc = p0;
        }
        else if (n <= 2)
        {
            strWartosc = std::to_string(p0);
            strWartosc += std::to_string(p1);
            intWartosc = stoi(strWartosc);
        }
        else
        {
            strWartosc += std::to_string(p0);
            strWartosc += std::to_string(p1);
            for( int index = n - 2; index > 0; index--)
            {
                Pi = (4 * p1 + p0) % q;

                strWartosc += std::to_string(Pi);
                p0 = p1;
                p1 = Pi;

            }
            intWartosc = stoi(strWartosc);
        }
        std::cout << ((intWartosc % q) == 0 ? "YES" : "NO") << std::endl;
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
