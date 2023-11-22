// CS50 Week 1
// Mario - More Comfortable Challenge 
/*
while (false) {
    Console.WriteLine("Choose a pyramid height.");
    int userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput > 0 && userInput < 9)
    {
        int pyramidHeight = userInput;
        int n = pyramidHeight;
        int m = pyramidHeight;
        int p = 0;
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                Console.Write(" ");
            }
            m--;
            for (int k = 0; k <= p; k++) {
                Console.Write("#");

            }
            Console.Write("  ");
            for (int l = 0; l <= p; l++) {
                Console.Write("#");
            }
            p++;
            Console.WriteLine();
        }
    }
}
*/
// Cash Challenge - Greedy algorithm 

/*
while (true)
{
    int change = 0;
    int coins = 0;
    int quarter = 0;
    int dime = 0;
    int nickel = 0;
    int penny = 0;

    do
    {
        Console.Write("Enter change amount..");
        change = Convert.ToInt32(Console.ReadLine());
    } while (change <= 0);


    while (change > 0)
    {
        if (change >= 25)
        {
            while (change >= 25)
            {
                change = change - 25;
                coins++;
                quarter++;
            }

        }
        if (change >= 10)
        {
            while (change >= 10)
            {
                change = change - 10;
                coins++;
                dime++;
            }
        }
        if (change >= 5)
        {
            while (change >= 5)
            {
                change = change - 5;
                coins++;
                nickel++;
            }
        }
        if (change >= 1)
        {
            while (change >= 1)
            {
                change = change - 1;
                coins++;
                penny++;
            }
        }

    }

    Console.WriteLine($" You should use {coins}coins " +
        $"\n{quarter} Quarter " +
        $"\n{dime} Dime " +
        $"\n{nickel} Nickel " +
        $"\n{penny} Penny");
    
}
*/

// Credit Challenge
long creditCardNumber;

do
{
    Console.Write("Enter card number");
    creditCardNumber = Convert.ToInt64((Console.ReadLine()));

} while (creditCardNumber <= 0);

long workingCCNum = creditCardNumber;
int sum1 = 0;

while (workingCCNum > 0)
{
    sum1 += workingCCNum % 10;
    workingCCNum = workingCCNum / 100;
}

workingCCNum = creditCardNumber;
long sum2 = 0;

while (workingCCNum > 0)
{
    workingCCNum = workingCCNum / 10;
    sum2 = workingCCNum % 10;
    sum2 = sum2 * 2;
    sum2 += (sum2 % 10) + (sum2 / 10);
}

long sum3 = (sum1 + sum2) % 10;

Console.WriteLine(sum3);