/*

Laboratory work on the subject "Structures and Data Processing Algorithms", on the topic "Hashing"
Implemented by a student of the group 18-PRI-RPS-B - Lyadov Vyacheslav Serveevich

The task:
Write an algorithm and program that uses functions
re-hashing, depending on the number of times re-hashing
hashes. Print input data, hash - table and
number of comparisons for different  sizes hashtables
*/

#include <iostream>

// The number of re-hashes
int CountReHahing = 1,
CountCompare = 0;



// Function to calculate the slot. Convolution method
int HashFunction(int Element, int SizeTable) 
{
	int Slot = 0;
	do
	{
		Slot += Element % 10;
		Element /= 10;
	} while (Element != 0);

	return Slot % SizeTable;
}

// Function Re-Hashing
int ReHashing(int Slot, int* HashTable, int SizeTable)
{
	while(true)
	{
		CountCompare++;
		Slot += 1;
		if (Slot >= SizeTable)
			Slot = 0;
		if (HashTable[Slot] == -1 && Slot < SizeTable )
		{
			break;
		}		
	}
	return Slot;
}


// Table fill function
int TableFilling(int* HashTable, int SizeTable, int* Data, int SizeData) {
	CountCompare = 0;
	for (int i = 0; i < SizeData; i++) {
		int Slot = HashFunction(Data[i], SizeTable);
		CountCompare++;
		//If the slot is free (value -1 == null), then we enter it in the table, 
		//otherwise we call the re-hash function
		if(HashTable[Slot] == -1)
		{
			HashTable[Slot] = Data[i];
		}	
		else 
		{
			// We use repeated hashing as many times as it was before.
			for (int j = 0; j < CountReHahing; j++)
			{
				Slot = ReHashing(Slot, HashTable, SizeTable);
			}
			CountReHahing++;
			HashTable[Slot] = Data[i];
		}
	}
	return 1;
}

void Print(int* HashTable, int SizeTable) {
	printf("\n\tHash Table, size = %d, compare = %d:\n\t---------------------\n\tIndex\tValue\n", SizeTable, CountCompare);
	for (int i = 0; i < SizeTable; i++) {
		printf("\t----\t----\n\t%d\t%d\n", i+1, HashTable[i]);
	}
}


int main() {

	// Initial data
	int HashTableOne[15],
		HashTableTwo[35],
		HashTableThree[100],
		HashTableFour[1000],
		DataOne[8] = { 1379, 2469, 5958, 6649, 3572, 7669, 8498, 5230 },
		DataTwo[30]{9941, 2681, 3676, 1457, 8322, 8426, 5679, 6326,
		5346, 5451, 3341, 5678, 3863, 6554, 9458, 5674, 8780, 6548, 7151,
		5110, 7353, 8212, 3517, 6665, 9437, 8579, 8649, 2868, 3736, 8357 };

	// Initialization with standard values
	for (int i = 0; i < 15; i++) {
		HashTableOne[i] = -1;
	}
	for (int i = 0; i < 35; i++) {
		HashTableTwo[i] = -1;
	}	
	for (int i = 0; i < 100; i++) {
		HashTableThree[i] = -1;
	}
	for (int i = 0; i < 1000; i++) {
		HashTableFour[i] = -1;
	}


	CountReHahing = 1;
	printf("Initial data:\n1:");
	for (int i = 0; i < 8; i++) {
		printf(" %d ", DataOne[i]);
	}
	TableFilling(HashTableOne, 15, DataOne, 8);
	Print(HashTableOne, 15);

	CountReHahing = 1;
	printf("\n2:");
	for (int i = 0; i < 30; i++) {
		printf(" %d ", DataTwo[i]);
	}
	TableFilling(HashTableTwo, 35, DataTwo, 30);
	Print(HashTableTwo, 35);

	CountReHahing = 1;
	printf("\n3:");
	for (int i = 0; i < 30; i++) {
		printf(" %d ", DataTwo[i]);
	}
	TableFilling(HashTableThree, 100, DataTwo, 30);
	Print(HashTableThree, 100);

	CountReHahing = 1;
	printf("\n4:");
	for (int i = 0; i < 30; i++) {
		printf(" %d ", DataTwo[i]);
	}
	TableFilling(HashTableFour, 1000, DataTwo, 30);
	Print(HashTableFour, 1000);

	getchar();
	return 1;
}
