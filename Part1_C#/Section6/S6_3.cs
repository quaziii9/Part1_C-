

namespace S6
{
     class S6_3
    {
        class Map
        {
            int[,] tiles = {
                { 1, 1, 1, 1, 1, },
                { 1, 0, 0, 0, 1, },
                { 1, 0, 0, 0, 1, },
                { 1, 0, 0, 0, 1, },
                { 1, 1, 1, 1, 1, },
            };


            public void Rander()
            {
                ConsoleColor defaultColor = Console.ForegroundColor;
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    for (int x = 0; x < tiles.GetLength(0); x++)
                    {
                        if (tiles[y, x] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();

                    Console.ForegroundColor = defaultColor;
                }
            }
        }
        static void Main(string[] args)
        {

            Map map = new Map();
            map.Rander();

            // int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            // int[,] arr = new int[2, 3] { {1,2,3 } , { 1,2,3,} };
            // //int[,] arr = new int[, ] { {1,2,3 } , { 1,2,3,} };
            //// int[,] arr = { { 1, 2, 3 }, { 1, 2, 3, } };

            // arr[0, 0] = 1;
            // arr[1, 0] = 1;

            int[,] map2 = new int[2, 3];

            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[6];
            a[2] = new int[2];

            a[0][0] = 1;

        }
    }

}
