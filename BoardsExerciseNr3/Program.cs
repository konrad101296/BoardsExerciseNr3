using System.Numerics;

int[] board = new int[10];
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    board[i] = random.Next();
    Console.WriteLine($"the {i + 1} element one the board is:" + board[i]);
}
int biggest = 0;
int smallest = Int32.MaxValue;
int biggestIndex = 0;
int smallestIndex = 0;
for (int i = 0; i < 10; i++)
{
    if (biggest < board[i])
    {
        biggest = board[i];
        biggestIndex = i + 1;
    }
    if (smallest > board[i])
    {
        smallest = board[i];
        smallestIndex = i + 1;
    }
}
Console.WriteLine($"the smallest value has index {smallestIndex} and is {smallest}");
Console.WriteLine($"the biggest value is {biggestIndex} and is {biggest}");