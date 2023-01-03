
namespace ConsoleApp1
{
    public class WithThreads : IMultiThreadingActionStart
    {
        readonly Action action = new(); 

        public void ActionStart(int iterator_length)
        {
            for (int i = 1; i <= iterator_length; i++)
            {
                Thread thread = new(new ThreadStart(action.RealAction));
                thread.Name = $"Thread number {i}";
                thread.Start();
            }
        }

    }
}
