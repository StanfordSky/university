// ���������� Radix Sort �� C++ // ����� �.�., ��. 18-���-���-� / ���� 
#include<iostream> 
using namespace std;

int count_compare = 0;
int count_move = 0;

// ������� ��� ���������� max � arr[] 
int getMax(int arr[], int n)
{
	int mx = arr[0];
	for (int i = 1; i < n; i++)
		if (arr[i] > mx) {
			mx = arr[i];
		}
	return mx;
}

// ������� �������� ���������� arr[]
void countSort(int arr[], int n, int exp)
{
	int output[100]; 
	int i, count[10] = { 0 };

	// ���������� ��������� � count
	for (i = 0; i < n; i++) {
		count[(arr[i] / exp) % 10]++;
	}

	// �������� count[], ����� �� �������� ���������� �������
	for (i = 1; i < 10; i++) {
		count[i] += count[i - 1];
	}

	// ������ ��� ������
	for (i = n - 1; i >= 0; i--)
	{
		output[count[(arr[i] / exp) % 10] - 1] = arr[i];
		count[(arr[i] / exp) % 10]--;
		count_move++;
	}

	// �������� count[] arr[]
	for (i = 0; i < n; i++) {
		arr[i] = output[i];
		count_move++;
	}
}
 
// Radix Sort 
void radixsort(int arr[], int n)
{
	// ���� max ����� � �������.
	int m = getMax(arr, n);

	// ������� ��� ������ �����.
	for (int exp = 1; m / exp > 0; exp *= 10)
		countSort(arr, n, exp);
}

// ������� ��� ������ ������� � �������. 
void print(int arr[], int n)
{
	for (int i = 0; i < n; i++)
		cout << arr[i] << " ";
	cout << "\nCompare = " << count_compare << ".\n";
	cout << "Move = " << count_move << ".\n";

}

// �������� �������
int main()
{
	int arr[] = { 10, 7, 8, 9, 1, 5, 3, 12, 99, 56, 42, 77, 88, 31, 2, 45, 43, 95, 91 };
	//int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 11, 13, 14, 15, 16, 17, 18, 19, 20 };
	int n = sizeof(arr) / sizeof(arr[0]);
	radixsort(arr, n);
	print(arr, n);
	return 0;
}