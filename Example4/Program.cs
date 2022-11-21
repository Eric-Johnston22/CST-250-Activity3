namespace Example4
{
    internal class Program
    {
        static int BoardSize = 8;
        static int attemptedMoves = 0;

        static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };

        static int[,] boardGrid = new int[BoardSize, BoardSize];

        static void Main(string[] args)
        {
            solveKT();
            Console.ReadKey();
        }

        /* This function solves the Knight tour problem using backtracking.*/
        static void solveKT()
        {
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    boardGrid[x, y] = -1;
                }
            }

            int startX = 0;
            int startY = 0;
            boardGrid[startX, startY] = 0;

            attemptedMoves = 0;

            if (!solveKTUtil(startX, startY, 1))
            {
                Console.WriteLine("Solution does not exist for {0} {1}", startX, startY);
            }
            else
            {
                printSolution(boardGrid);
                Console.WriteLine("Total attempted moves {0}", attemptedMoves);
            }
        }

        static bool solveKTUtil(int x, int y, int moveCount)
        {
            attemptedMoves++;
            if (attemptedMoves % 1000000 == 0)
            {
                Console.WriteLine("Attempts: {0}", attemptedMoves);
            }

            int k, next_x, next_y;

            if (moveCount == BoardSize * BoardSize)
            {
                return true;
            }

            for (k = 0; k < 8; k++)
            {
                next_x = x + xMove[k];
                next_y = y + yMove[k];
                int count = countVisitedNeighbors(next_x, next_y);

                if(count == 8)
                {
                    if (isSquareSafe(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
                if (count == 7)
                {
                    if (isSquareSafe(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
                if (count == 6)
                {
                    if (isSquareSafe(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
                if (count == 5)
                {
                    if (isSquareSafe(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
                if (count == 4)
                {
                    if (isSquareSafe(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
                if (count == 3)
                {
                    if (isSquareSafe(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
                if (count == 2)
                {
                    if (isSquareSafe(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
                if (count == 1)
                {
                    if (isSquareSafe(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
                if (count == 0)
                {
                    if (isSquareSafe(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
            }
            return false;
        }

        static bool isSquareSafe(int x, int y)
        {
            return (x >= 0 && x < BoardSize &&
                    y >= 0 && y < BoardSize &&
                    boardGrid[x, y] == -1);
        }

        static void printSolution(int[,] solution)
        {
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    Console.Write(solution[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool squareVisited(int x, int y)
        {
            return (x >= 0 && x < BoardSize &&
                    y >= 0 && y < BoardSize &&
                    boardGrid[x, y] != -1);
        }

        static int countVisitedNeighbors(int x, int y)
        {
            int count = 0;
            if (squareVisited(x - 1, y))
            {
                count++;
            }
            if (squareVisited(x, y - 1))
            {
                count++;
            }
            if (squareVisited(x -1, y - 1))
            {
                count++;
            }
            if (squareVisited(x + 1, y))
            {
                count++;
            }
            if (squareVisited(x, y + 1))
            {
                count++;
            }
            if (squareVisited(x + 1, y + 1))
            {
                count++;
            }
            if (squareVisited(x - 1, y + 1))
            {
                count++;
            }
            if (squareVisited(x + 1, y - 1))
            {
                count++;
            }

            return count;
        }

    }
}