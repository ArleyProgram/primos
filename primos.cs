Console.WriteLine("Ingresa el numero hasta cual deseas saber los primos ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 2;
int c = 1;
int d = 0;

while (b <= a)
{
	while (c <= b)
	{
		if (b % c == 0)
		{
			d++;
		}
		c++;
	}

	if (d == 2)
	{
		Console.WriteLine(b);
	}
	b++;
	c = 1;
	d = 0;
}
