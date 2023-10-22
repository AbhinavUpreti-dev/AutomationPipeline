using AutomationPipeline.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPipeline.Concrete
{
    public class DownloadFile : IChoice
    {
        public async Task Operation()
        {
            Console.Write("Enter source url: ");
            string sourceUrl = Console.ReadLine();
            Console.Write("Enter output file: ");
            string outputFile = Console.ReadLine();
            using (WebClient webClient = new WebClient())
            {
                await Task.Run(new Action(()=>webClient.DownloadFile(sourceUrl, outputFile)));
            }
        }
    }
}
