int a = 5;
int b = 3;
int c = 9;
int d = 1;
int e = 8;
int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine("Максимальное значение " + max);
