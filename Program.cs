while (true) {
    Console.WriteLine("Choose a pyramid height.");
    int userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput > 0 && userInput < 9)
    {
        int pyramidHeight = userInput;
        int n = pyramidHeight;
        int m = pyramidHeight;
        int p = 0;
        int q = 0;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                Console.Write(" ");
            }
            m--;
            for (int k = 0; k <= p; k++) {
                Console.Write("#");
            }
            p++;
            Console.Write("  ");
            for (int l = 0; l <= q; l++) {
                Console.Write("#");
            }
            q++;
            Console.WriteLine();
        }
    }
}
    

