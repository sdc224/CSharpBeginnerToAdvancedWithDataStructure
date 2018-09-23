using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (var workflow in workFlow.GetTasks())
            {
                workflow.Execute();
            }
        }
    }
}