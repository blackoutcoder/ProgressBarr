using System;
using System.Threading.Tasks;

namespace ProgressBarr
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ProgressBar progressBarr = new ();
            WriteProgress(progressBarr);
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(1000);
                progressBarr.Progress++;
                
            }
        }

        static async Task WriteProgress(ProgressBar progressBar)
        {
            while(true)
            {
                Console.Clear();
                Console.Write(progressBar.Progress);
                await Task.Delay(3000);
            }
        }
    }
}
