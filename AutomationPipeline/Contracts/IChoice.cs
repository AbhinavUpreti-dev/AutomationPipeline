using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPipeline.Contracts
{
    public interface IChoice
    {
       public Task Operation();
    }
}
