/*

Laboratory work on the subject "Structures and Data Processing Algorithms", on the topic "Graph #1"
Implemented by a student of the group 18-PRI-RPS-B - Lyadov Vyacheslav Serveevich

Разработать программу поиска остовного дерева грубым методом и методом поиска в глубину.
Оценить эффективность программ на произвольных графах.

*/

#include <iostream>
#include <vector>
using namespace std;

// data structure to store graph edges
struct Edge {
	int src, dest;
};

class Graph
{
public:
	// construct a vector of vectors to represent an adjacency list
	vector<vector<int>> adjL;

	// Graph Constructor
	Graph(vector<Edge> const& edges, int N)
	{
		// resize the vector to N elements of type vector<int>
		adjL.resize(N);

		// add edges to the undirected graph
		for (auto& edge : edges)
		{
			adjL[edge.src].push_back(edge.dest);
			adjL[edge.dest].push_back(edge.src);
		}
	}
};

// Function to perform DFS Traversal
void DFS(Graph const& graph, int v, vector<bool>& discovered)
{
	// mark current node as discovered
	discovered[v] = true;

	// print current node
	printf(" %d ", v);

	// do for every edge (v -> u)
	for (int u : graph.adjL[v])
	{
		// u is not discovered
		if (!discovered[u])
			DFS(graph, u, discovered);
	}
}

// Depth First Search (DFS)
int main()
{
	// vector of graph edges
	vector<Edge> edges = {
		{1, 2}, {1, 4}, {1, 7}, {1, 8}, {2, 3}, {2, 6},
		{4, 7} , {3, 5}, {3, 6}, {7, 9}, {7, 10}, {8, 9},
	};

	// Number of nodes in the graph (0-10)
	int N = 11;

	// create a graph from given edges
	Graph graph(edges, N);

	// stores vertex is discovered or not
	vector<bool> discovered(N);

	printf(" The result (spanning tree) of a transferring by searching depth first search (DFS) in the graph: \n");

	// Do DFS traversal from all undiscovered nodes to
	// cover all unconnected components of graph
	for (int i = 1; i < N; i++)
		if (discovered[i] == false)
			DFS(graph, i, discovered);

	return 0;
}