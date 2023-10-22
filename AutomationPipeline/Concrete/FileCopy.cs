using AutomationPipeline.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPipeline.Concrete
{
    public class FileCopy : IChoice
    {
        public async Task Operation()
        {            
            Console.Write("Enter source file: ");
            string sourceFile = Console.ReadLine();
            Console.Write("Enter destination file: ");
            string destinationFile = Console.ReadLine();
            await Task.Run(new Action(()=>File.Copy(sourceFile, destinationFile)));
            Console.WriteLine($"\n File {sourceFile} SuccessFully Copied to {destinationFile}");
        }
    }
}
