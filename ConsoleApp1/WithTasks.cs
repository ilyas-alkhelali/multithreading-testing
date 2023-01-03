using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class WithTasks : IMultiThreadingActionStart
    {
        readonly Action action = new();

        public void ActionStart(int iterator_length)
        {
            for (int i = 0; i < iterator_length; i++)
            {
                Task task = new(action.RealAction);
                task.Start();
            }

            Console.ReadLine();
        }
    }
}
