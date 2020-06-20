/*

Laboratory work on the subject "Structures and Data Processing Algorithms", on the topic "Graph #1" 
Implemented by a student of the group 18-PRI-RPS-B - Lyadov Vyacheslav Serveevich

Разработать программу поиска остовного дерева грубым методом и методом поиска в глубину.
Оценить эффективность программ на произвольных графах.

*/


#include <iostream>
using namespace std;

// Data structure to store graph edges
struct Edge {
	int src, dest, weight;
};

// Check element in arr[]
bool checkArray(int* arr, int size, int element)
{
	for (int i = 0; i < size; i++)
	{
		if (arr[i] == element)
			return true;
	}
	return false;
}


// Check src and dest in SpanningTree
bool checkSpanningTree(Edge *SpanningTree, int size, int src, int dest) {
	for (int i = 0; i < 10; i++) {
		if (SpanningTree[i].dest == dest || SpanningTree[i].src == dest)
		{
			for (int j = 0; j < 10; j++)
			{
				if (SpanningTree[j].dest == src || SpanningTree[j].src == src)
					return true;
			}
		}
	}

	for (int i = 0; i < 10; i++) {
		if (SpanningTree[i].dest == src || SpanningTree[i].src == src)
		{
			for (int j = 0; j < 10; j++)
			{
				if (SpanningTree[j].dest == dest || SpanningTree[j].src == dest)
					return true;
			}
		}
	}
	return false;
}

// "Грубый метод"
int main()
{
	// Array of graph edges
	Edge edges[] =
	{
		// (x, y, w) -> edge from x to y having weight w
		{ 0, 1, 6 }, { 1, 2, 7 }, 
		{ 2, 0, 5 }, { 2, 1, 4 },
		{ 3, 2, 10 }, 
	};

	// Initial value
	Edge SpanningTree[10];
	Edge Edge_temp;

	// Initialization  initial array - Spanning Tree
	for (int i = 0; i < 10; i++)
	{
		SpanningTree[i].dest = -1;
		SpanningTree[i].src = -1;
		SpanningTree[i].weight = -1;
	}

	// Number of vertices in the graph, variable for loop
	int N = 4, MinEdge = 1000, item;

	// Helper arrays
	int CheckedElement[4] = { -1,-1,-1,-1 };
	int CheckedVertex[10] = { -1,-1,-1,-1,-1,-1,-1,-1, -1, -1 };
	bool Enter = false;

	// Сalculate number of edges
	int n = sizeof(edges) / sizeof(edges[0]);

	// Main loop
	for (int j = 0; j < n; j++) {
		for (int i = 0; i < n; i++)
		{	
			// Searching min unique edge
			if (MinEdge > edges[i].weight && 
				!checkArray(CheckedElement, 4, edges[i].weight) && 
				!checkSpanningTree(SpanningTree, 10, edges[i].src, edges[i].dest)) {

				// Saving value min edge
				MinEdge = edges[i].weight;
				Edge_temp = edges[i];
				item = i;

				Enter = true;
			}
		}

		// Checking that found min unique edge
		if (Enter) {

			// print in console
			printf("(%d, %d, %d)\n", Edge_temp.dest, Edge_temp.src, Edge_temp.weight);

			// Saving data about found edge
			for (int a = 0; a < 4; a++)
			{
				if (CheckedElement[a] == -1) {
					CheckedElement[a] = Edge_temp.weight;
					break;
				}
			}

			for (int a = 0; a < 10; a++) {
				if (SpanningTree[a].dest == -1 && SpanningTree[a].src == -1) {
					SpanningTree[a].dest = Edge_temp.dest;
					SpanningTree[a].src = Edge_temp.src;
					break;
				}
			}

			// Updating helper values
			MinEdge = 1000;
			Enter = false;
		}		
	}
	
	return 0;
}