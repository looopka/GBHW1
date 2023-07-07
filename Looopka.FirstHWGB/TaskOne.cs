using Looopka.FirstHWGB;
using System.Reflection.Metadata.Ecma335;

static int start()
{
    Console.WriteLine("Привет, выбери доступную функцию:");
    Functions.PrintFunctions();
    string answer = Console.ReadLine();
    return Functions.GetTask(answer);

}
int status = 0;
while (status == 0)
{
    status = start();
    
}
    

