Console.Clear();
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80,yc = 30; 
int x = xa, y = ya;
int count = 0;
while (count <= 10000)
{
    int median = new Random().Next(0, 3);
    if (median == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
      if (median == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
      if (median == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}