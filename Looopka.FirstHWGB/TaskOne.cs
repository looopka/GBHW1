using Looopka.FirstHWGB;
using System.Reflection.Metadata.Ecma335;

static int start()
{
    Console.WriteLine("Привет, выбери доступную функцию:");
    Functions.PrintFunctions();
    string answer = Console.ReadLine();
    Functions.GetTask(answer);
    switch (answer)
    {
        case "quit":
        return 1;
        default: return 0;

    }

}
int status = 0;
while (status == 0)
{
    status = start();
    
    
}
    

