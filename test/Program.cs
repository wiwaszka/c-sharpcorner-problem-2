int e = 0;
int  arrayLenght = 3;
char x = 'x';
char y = 'y';

int[] xPoints = new int[arrayLenght];
int[] yPoints = new int[arrayLenght];

for (int i = 0; i < arrayLenght; i++)
{
    
    xPoints[e] = TakeInput(x);
    
    yPoints[e] = TakeInput(y);
    
    e++;
}


for (int i = 0; i < arrayLenght; i++)
{
    Console.WriteLine(x + "" + xPoints[i] + " " + y + "" + yPoints[i]);
}

if ((yPoints[1] - yPoints[0]) == (xPoints[1] - xPoints[0]) * (yPoints[2] - yPoints[1]))
{
    Console.WriteLine("The points line up");
}
else
{
    Console.WriteLine("The points DON'T line up");
}

int TakeInput(char c)
{
    Console.WriteLine("input " + c + ": ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(c + " = " + a);
    Console.WriteLine("");
    return a;
}

