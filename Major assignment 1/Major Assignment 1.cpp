// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include<ctime>
#include <string>
#include<iomanip>

using namespace std;

int main()
{
	srand(time(NULL));

	int number1 = 6;
	int number2 = 6;
	int nrOfThrows = 0;
	int result1 = 0;
	int result2 = 0;
	int total = 0;
	
	cout << "Push bottom 1 to play the game";
		cin >> nrOfThrows;

	cout << "Dice1 = rand() % number1 + 1" << endl;
	cout << "Dice2 = rand() % number2 + 1" << endl;

	result1 = rand() % number1 + 1;

		result2 = rand() % number2 + 1;
	
		if (result1 !=1,3,5 || result2 !=1,3,5)
		{
			cout << "I got result1 and result2" << endl;
			cout << "Evens are better than odds!" << endl;
		}
		else
		{
			cout << "I got result1 and result2" << endl;
			cout << "Odds are still cool!" << endl;
		}
	
	cout << "if you want to play game push bottom 1";
	cin >> nrOfThrows;
	
	cout << "If you don't want to play anymore push bottom 0";
	cin >> nrOfThrows;
	for (int i = 0; i < nrOfThrows; i++)
	{
		if (result1 != 1, 3, 5 || result2 != 1, 3, 5)
		{
			cout << "I got result1 and result2" << endl;
			cout << "Evens are better than odds!" << endl;
		}
		else
		{
			cout << "I got result1 and result2" << endl;
			cout << "Odds are still cool!" << endl;
		}

	}


	system("PAUSE");

		return 0;
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
