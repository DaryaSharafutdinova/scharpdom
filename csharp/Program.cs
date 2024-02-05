namespace ConsoleApp1
{
    internal class Program
    {

        static void Exercise1()
        {
            int print(int X, int Y)
            {
                System.Console.WriteLine(X);
                if (X < Y - 1) print(X + 1, Y);
                return 0;
            }
            Console.WriteLine("Write M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            print(M, N);
        }
        static void Exercise2()
        {
            int DoAkkerman(int m, int n)
            {
                int a = 0;
                if (m == 0)
                {
                    a = n + 1;
                }
                else if ((m > 0) && (n == 0))
                {
                    a= DoAkkerman(m - 1, 1);
                }
                else if ((m > 0) && (n > 0))
                {
                    int k = DoAkkerman(m, n - 1);
                    a = DoAkkerman(m - 1, k);
                }
                return a;
                

            }
            Console.WriteLine("Write M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(DoAkkerman(M, N));
        }
        static void Exercise3(){
            int[] array={1,2,3,4,5,6};
            void printElement(int[] a, int n){
                System.Console.WriteLine(a[n]);
                n-=1;
                if (n>=0) printElement(a,n);
            }
            printElement(array,array.Length-1);
        }
        static void Main()
        {
            //Exercise1();
            //Exercise2();
            Exercise3();

        }

    }
}