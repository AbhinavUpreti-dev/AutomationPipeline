using AutomationPipeline.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPipeline.Concrete
{
    public class FileDelete : IChoice
    {
        public async Task Operation()
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();
            await Task.Run(new Action(()=>File.Delete(filePath)));
            Console.WriteLine($"File {filePath} deleted successfully");
        }
    }
}
