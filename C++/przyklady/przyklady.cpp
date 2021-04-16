// przyklady.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <ctime>

using namespace std;

auto mnozenie(int a, int b) -> long;
auto dodanie(int a, double b) -> decltype(a); \
auto randFunckje(int &&a) -> void;

int main()
	{
		cout << mnozenie(4, 8) << endl;
		cout << dodanie(4, 8.5) << endl;

		srand(time(NULL));

		randFunckje(rand() % 20 + 1);


		return 0;
	}

auto mnozenie(int a, int b) -> long
{
	return a * b;
}

auto dodanie(int a, double b) -> decltype(a)
{
	return a + b;
}

auto randFunckje(int&& a) -> void
{
	for (int i = 0; i < 10; i++)
	{
		auto randFunckje(int&& a);
		cout << a << " ";
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
