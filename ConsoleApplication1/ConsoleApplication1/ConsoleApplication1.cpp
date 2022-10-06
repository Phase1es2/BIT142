// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include<ctime>
#include <string>
#include<iomanip>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int main()
{
	srand(time(NULL));

	int number = 6;
	int result = 0;

	result = rand() % number + 1;
	
	switch (number)
	{
	case 1:
		cout << "what are you doing?" << endl;
			break;
	case 6:
		cout << "what are you doing?" << endl;
		break;
		default;
		cout << "Browski waht you doing?" << endl;
		break;
	
	}
	system("PAUSE")

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
