//tamrin 4-fibonachi -  amir mahdi hosein njad

int a = -1;
int b = 1;
do
{
    Console.WriteLine("adad morede nazar baray donbale fibonachi ra vared konid");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < number; i++)
    {
    
        int sum = a + b;
        a = b;
        b = sum;

        Console.WriteLine("===>  "   +sum  );
    }
    Console.WriteLine("mikhay edame bedy?y n");
}  while (Console.ReadLine() == "y");
Console.WriteLine("---payan---");