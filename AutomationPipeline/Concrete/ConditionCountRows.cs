using AutomationPipeline.Contracts;

namespace AutomationPipeline.Concrete
{
    public class ConditionalCountRows : IChoice
    {
        public async Task Operation()
        {
            Console.Write("Enter source file: ");
            var sourceFile = Console.ReadLine();
            Console.Write("Enter string to search: ");
            string searchString = Console.ReadLine();
            int count = 0;
            using (StreamReader reader = new StreamReader(sourceFile))
            {
                string line;
                await Task.Run(new Action(() => {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(searchString))
                        {
                            count++;
                        }
                    }
                }));
              
            }
            Console.WriteLine("Count of rows in the file that contain the search string: {0}", count);
        }
    }
}
