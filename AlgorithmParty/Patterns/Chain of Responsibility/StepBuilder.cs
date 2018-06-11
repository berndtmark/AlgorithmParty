using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Patterns.Chain_of_Responsibility
{
    public class StepBuilder
    {
        private readonly IList<Step> _steps;
        private readonly object _params;

        public StepBuilder(object param)
        {
            _params = param;
            _steps = new List<Step>();
        }

        public StepBuilder Add(Step step)
        {
            _steps.Add(step);

            return this;
        }

        public StepBuilder Run()
        {
            foreach (var step in _steps)
            {
                step.Execute(_params);
            }

            return this;
        }
    }
}
