// ���������� Quick Sort �� C++ // ����� �.�., ��. 18-���-���-� / ���� 
#include<iostream> 
using namespace std;


int count_compare = 0;
int count_move = 0;


// ������� ��� ������ �������.
void swap(int* a, int* b)
{
	int t = *a;
	*a = *b;
	*b = t;
	count_move++;
}


/*������� ��������� ��������� ������� � �������� ���������,
��� �������� ������ �������, ���������� �����, ��� ��� ���� - ������*/
int partition(int arr[], int low, int high)
{
	int pivot = arr[high]; // �������� �������
	int i = (low - 1); // ������ ��������� �������� 

	for (int j = low; j <= high - 1; j++)
	{
		if (arr[j] <= pivot)
		{
			i++;
			count_compare++;
			swap(&arr[i], &arr[j]);
		}
	}
	swap(&arr[i + 1], &arr[high]);
	return (i + 1);
}

// Quick Sort
void quickSort(int arr[], int low, int high)
{
	if (low < high)
	{
		count_compare++;
		int pi = partition(arr, low, high);

		quickSort(arr, low, pi - 1);
		quickSort(arr, pi + 1, high);
	}
}

// ������� ��� ������ ������� � �������.
void printArray(int arr[], int size)
{
	for (int i = 0; i < size; i++)
		cout << arr[i] << " ";
	cout << "\nCompare = " << count_compare << ".\n";
	cout << "Move = " << count_move << ".\n";
}

// �������� �������
int main()
{
	//int arr[] = { 10, 7, 8, 9, 1, 5, 3, 12, 99, 56, 42,77, 88, 31, 2, 45, 43, 95, 91 };
	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 11, 13, 14, 15, 16, 17, 18, 19, 20 };
	int n = sizeof(arr) / sizeof(arr[0]);
	quickSort(arr, 0, n - 1);
	printf("Sorted array: ");
	printArray(arr, n);
	return 0;
}
