// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

int numleng = 3;
int a = 1;
int b = 2;
int c = 3;

int max = a;
int i = 0;

while (i < numleng)
{
    if (max < b)
    {
        int max = b;
        i++;
    }
    else
    {
       if (max < c)
       {
        int max = c;
        i++;
       }
       else
       {
        int max = a;
        i++;
       }
    }
}
Console.WriteLine(max);