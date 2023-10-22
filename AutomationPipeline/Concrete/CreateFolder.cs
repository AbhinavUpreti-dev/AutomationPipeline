using AutomationPipeline.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPipeline.Concrete
{
    public class CreateFolder : IChoice
    {
        public async Task Operation()
        {
            Console.Write("Enter folder path: ");
            var folderPath = Console.ReadLine();
            Console.Write("Enter new folder name: ");
            string folderName = Console.ReadLine();
            await Task.Run(new Action(()=>Directory.CreateDirectory(Path.Combine(folderPath, folderName))));
        }
    }
}
