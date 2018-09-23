using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class WorkFlow : IWorkFlow
    {
        private readonly IList<ITask> _tasks;

        public WorkFlow()
        {
            _tasks = new List<ITask>();
        }
        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}