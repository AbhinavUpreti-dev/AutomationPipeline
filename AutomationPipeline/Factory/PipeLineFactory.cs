using AutomationPipeline.Concrete;
using AutomationPipeline.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPipeline.Factory
{
    public static class PipeLineFactory
    {
        public static IChoice? GetChoice(string? input)
        {
            switch (input)
            {
                case "1":                    
                    return new FileCopy();
                case "2":
                    return new FileDelete();
                case "3":
                    return new QueryFolderFiles();
                case "4":
                    return new CreateFolder();
                case "5":
                    return new DownloadFile();
                case "6":
                    return new Wait();
                case "7":
                    return new ConditionalCountRows();
                case "8":
                    return new Exit();
                default:
                    Console.WriteLine("Invalid choice");
                    return null;
            }
        }
    }
}
