using AutomationPipeline.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPipeline.Concrete
{
    public class Exit : IChoice
    {
        public Task Operation()
        {
            Environment.Exit(0);
            return Task.CompletedTask;
        }
    }
}
