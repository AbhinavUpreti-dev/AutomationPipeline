using AutomationPipeline.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPipeline.Concrete
{
    public class Wait : IChoice
    {
        public async Task Operation()
        {
           Console.Write("Enter wait time in seconds: ");
           int waitTime = int.Parse(Console.ReadLine());
           await Task.Delay(waitTime * 1000);
           Console.WriteLine($"\n Wait of {waitTime} is over");
        }
    }
}
