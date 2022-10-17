#include<iostream>
using namespace std;
//function for part A.
void passengers_for_day(int arr[4][5])
{
	cout << "PART 'A' :\n" << endl;
	int day=1;
	int bus[4][5];
	cout << "ENTER THE VALUES OF MATRIX :" << endl;
	for (int col=0;col<5;col++)
	{
		for(int row=0;row<4;row++)
		{
			cin >> bus[row][col];
		}
	}
	for (int col = 0; col < 5; col++)
	{
		cout << "GIVEN NUMBER OF PASSENGERS FOR DAY "<<day<<" :";
		for (int row = 0; row < 4; row++)
		{
			cout << bus[row][col] <<" ";
		}
		cout << endl;
		day++;
		cout << endl;
	}
}
//function for part B.
void num_of_passengers(int arr[4][5])
{
	cout << "PART 'B' :\n" << endl;
	int day = 1;
	for (int col = 0; col < 5; col++)
	{
		int sum = 0;
		cout << "GIVEN NUMBER OF PASSENGERS FOR DAY " << day << " :";
		for (int row = 0; row < 4; row++)
		{
			cout << arr[row][col] << " ";
			sum += arr[row][col];
		}
		//cout << endl;
		cout <<"TOTAL NUMBER OF PASSENGER FOR DAY "<<day<<" : " << sum;
		cout << endl;
		day++;
	}
	cout << endl;
}
//function for part C.
void passengers_for_route0(int arr[4][5])
{
	cout << "PART 'C' :\n" << endl;
	int sum = 0;
	for (int col = 0; col < 5; col++)
	{
		for (int row = 0; row <= 0; row++)
		{
			sum += arr[row][col];
		}
	}
	cout << "NUMBER OF PASSENGER FOR ROUTE 0 : " << sum << endl;
	cout << endl;
}
//function for part D.
void min_passenger_thu(int arr[4][5])
{
	cout << "PART 'D' :\n" << endl;
	int min = 0;
	for (int col = 3; col <= 3; col++)
	{
		for (int row = 0; row < 4; row++)
		{
			cout << arr[row][col] << endl;
			{
				if (arr[row][col] < min)
					min = arr[row][col];				
			}			
		}
		cout << endl;
		cout <<"MINIMUM NUMBER OF PASSENGER FOR THURSDAY : "<< min << endl;
		cout << endl;	
	}
}
//function for part E.
void average(int arr[4][5])
{
	cout << "PART 'E' :\n" << endl ;
	int day = 1,route=0, sum = 0,sum2=0, average1=0, average2=0;
	for (int col = 0; col < 5; col++)
	{
		cout << "GIVEN NUMBER OF PASSENGERS FOR DAY " << day << " :";
		for (int row = 0; row < 4; row++)
		{
			cout << arr[row][col] << " ";
			sum += arr[row][col];
		}
		cout << "SUM :" << sum;
		cout << endl;
		average1 = sum / 5;
		cout << "AVERAGE OF DAY " << day << " = " << average1 << endl;
		day++;	
	}
	for (int row = 0; row < 4; row++)
	{
		cout << "GIVEN NUMBER OF PASSENGERS FOR ROUTES " << route << " :";
			for (int col = 0; col < 5; col++)
		{
			cout << arr[row][col] << " ";
			sum2 += arr[row][col];
		}
		cout << "SUM :" << sum;
		cout << endl;
		average2 = sum2 / 4;
		cout << "AVERAGE OF ROUTE " << route<<" = " << average2 << endl;
		route++;
		day++;
	}
	cout << endl;
}
//function for part F.
void row_largest_no_of_passenger(int arr[4][5])
{
	cout << "PART 'F' :\n" << endl;
	int largest = 0, index_i=0, index_j=0;
	for (int row = 0; row < 4; row++)
	{
		for (int col = 0; col < 5; col++)
		{
			cout << arr[row][col] << " ";
			if (arr[row][col]>largest)
			{
				largest = arr[row][col];
				index_i = row;
				index_j = col;
			}
		}
		cout << endl;
	}
	cout << endl;
	cout <<"LARGEST VALUE IN ALL ROUTES AND DAYS : "<< largest<<endl;
	cout << "THE INDEX OF LARGEST VALUE : ( "<<index_i<<" ),( "<<index_j<<" )" << endl;
}
int main()
{
	int bus[4][5] = { {8,12,9,7,10},{5,7,3,0,4},{20,15,18,21,14},{6,9,5,8,11} };
	passengers_for_day(bus);
	num_of_passengers(bus);
	passengers_for_route0(bus);
	min_passenger_thu(bus);
	average(bus);
	row_largest_no_of_passenger(bus);
	system("pause>0");
}
