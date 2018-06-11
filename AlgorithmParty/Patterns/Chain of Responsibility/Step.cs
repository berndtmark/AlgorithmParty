using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Patterns.Chain_of_Responsibility
{
    public abstract class Step
    {
        private Step _nextStep;

        protected abstract void Process(object param);

        public virtual void Next(Step step)
        {
            _nextStep = step;
        }

        public void Execute(object param)
        {
            Process(param);

            _nextStep?.Process(param);
        }
    }
}
