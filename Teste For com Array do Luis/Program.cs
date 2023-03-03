namespace std
{
    class Progrma
    {
        static void Main(string[] args)
        {
            int n0 = 0, n1 = 1, n2 = 2, n3 = 3, n4 = 4, n5 = 5, n6 = 2, n7 = 7, n8 = 8;

            int[] array = new int[]
            {
            n0, n1, n2,
            n3, n4, n5,
            n6, n7, n8
            };

            for(int a=0; a<8; a++)
            {
                for(int b=(a+1); b<9; b++)
                {
                    if (array[a] == array[b])
                    {
                        Console.Write("caractere na posição: ");
                        Console.Write(a);
                        Console.Write(" é igual a o caractere na posição: ");
                        Console.WriteLine(b);
                    }
                }
            }
        }
    }
}