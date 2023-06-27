using System;

namespace GraphTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] adjacencyMatrix = { {0, 1, 1, 0},
                                       {1, 0, 1, 1},
                                       {1, 1, 0, 1},
                                       {0, 1, 1, 0} };

            int vertexCount = adjacencyMatrix.GetLength(0);
            int edgeCount = 0;

            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = i + 1; j < vertexCount; j++)
                {
                    if (adjacencyMatrix[i, j] == 1)
                    {
                        edgeCount++;
                    }
                }
            }

            Console.WriteLine("Количество вершин: " + vertexCount);
            Console.WriteLine("Количество ребер: " + edgeCount);
        }
    }
}
