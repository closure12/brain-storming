using system 
class Goto 
{
    public static void main()
    {
        for(int i = 1 ; i < 100; i++)
        {
            console.Writeline(" ");
            if(i >= 10)
            break;
            for (int j = 1 ; j < 100; j++)
            {
                Console.Write("@");
                if (j == i) 
                goto loop1;
          }
          loop1:continue;
        }
        Console.Writeline("termination by BREAK");
    }
}