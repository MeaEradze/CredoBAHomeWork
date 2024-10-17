
//წესით ეს ბევრად უფრო მარტივი ინტერფეისია შევეცადე წინა დავალების ხარვეზი გამომესწორებინა

char[,] matrics = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, };
CreateAGame(matrics);
static void CreateAGame(char[,] matrics)
{
    int movesCount = 0;
    bool playerStarts = FlipACoin(); // Decide who starts
    char playerToken = playerStarts ? 'X' : 'O';
    char computerToken = playerStarts ? 'O' : 'X';

    while (true)
    {
        if (playerStarts)
        {
            PrintMatrix(matrics);
            PlayerMove(ref matrics, playerToken);
            movesCount++;
            if (CheckWinner(matrics, playerToken))
            {
                PrintMatrix(matrics);
                Console.WriteLine("Congratulations, you win!");
                break;
            }
        }

        if (BoardIsFull(matrics))
        {
            PrintMatrix(matrics);
            Console.WriteLine("It's a draw!");
            break;
        }

        Console.WriteLine("Computer's turn...");
        ComputerMove(ref matrics, computerToken);
        movesCount++;
        if (CheckWinner(matrics, computerToken))
        {
            PrintMatrix(matrics);
            Console.WriteLine("Computer wins!");
            break;
        }

        if (BoardIsFull(matrics))
        {
            PrintMatrix(matrics);
            Console.WriteLine("It's a draw!");
            break;
        }

        playerStarts = true;
    }
}

static void PrintMatrix(char[,] matrix)
{
    Console.WriteLine("   0   1   2 ");
    Console.WriteLine("  -----------");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(i + "|");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == ' ')
                Console.Write("  ");
            else
                Console.Write(" " + matrix[i, j]);
            if (j < matrix.GetLength(1) - 1)
                Console.Write(" |");
        }

        Console.WriteLine(" |");
        Console.WriteLine("  -----------");
    }
}
static bool FlipACoin()
{
    Console.WriteLine("Are you ready for tic-tack-toe?");
    Console.WriteLine("Lets begin with flipping a coin!");
    Console.WriteLine("If it's true you begin and are X, if it's false I begin and you are O");
    Random r = new Random();
    int x = r.Next(0, 2);
    if (x == 1)
    {
        Console.WriteLine("You are X, you are starting the game");
        return true;
    }
    Console.WriteLine("You are O, Computer is starting the game");
    return false;
}
static bool IndexIsEmpty(int i, int j, char[,] matrics)
{
    return matrics[i, j] == ' ';
}

static bool CheckWinner(char[,] matrics, char player)
{
    for (int i = 0; i < 3; i++)
    {
        if ((matrics[i, 0] == player && matrics[i, 1] == player && matrics[i, 2] == player) ||
            (matrics[0, i] == player && matrics[1, i] == player && matrics[2, i] == player))
        {
            return true;
        }
    }
    if ((matrics[0, 0] == player && matrics[1, 1] == player && matrics[2, 2] == player) ||
        (matrics[0, 2] == player && matrics[1, 1] == player && matrics[2, 0] == player))
    {
        return true;
    }
    return false;
}
static bool BoardIsFull(char[,] matrics)
{
    foreach (var item in matrics)
    {
        if (item == ' ')
            return false;
    }
    return true;
}
static void PlayerMove(ref char[,] matrics, char token)
{
    bool madeMove = true;

    while (madeMove)
    {
        Console.Write("Enter your i index: ");
        int iIndex = Convert.ToInt32(Console.ReadLine());
        if (iIndex >= 0 && iIndex <= 2)
        {
            Console.Write("Enter your j index: ");
            int jIndex = Convert.ToInt32(Console.ReadLine());
            if (jIndex >= 0 && jIndex <= 2 && IndexIsEmpty(iIndex, jIndex, matrics))
            {
                matrics[iIndex, jIndex] = token;
                madeMove = false;
            }
        }
        else
        {
            Console.WriteLine("Your i index is out of range, Please enter it again");
        }
    }

}
static void ComputerMove(ref char[,] matrics, char token)
{
    Random r = new Random();
    bool madeMove = true;

    while (madeMove)
    {
        int iIndex = r.Next(0, 3);
        int jIndex = r.Next(0, 3);
        if (IndexIsEmpty(iIndex, jIndex, matrics))
        {
            matrics[iIndex, jIndex] = token;
            madeMove = false;
        }
    }
}
