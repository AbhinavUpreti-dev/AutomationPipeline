using AutomationPipeline.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPipeline.Concrete
{
    public class QueryFolderFiles : IChoice
    {
        public async Task Operation()
        {
            Console.Write("Enter folder path: ");
            string folderPath = Console.ReadLine();
            string[] files = await Task.Run(new Func<string[]>(()=>Directory.GetFiles(folderPath)));
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
