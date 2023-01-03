namespace ConsoleApp1
{
    public class Action
    {
        readonly Mutex mutex = new();
        //action with real activities
        public void RealAction()
        {
            Console.WriteLine($"Start {Thread.CurrentThread.Name}, Threads running {RunningThreadsCount()}");
            for (int i = 0; i < 50900; i++)
            {
                Console.Write("");
            }
            Console.WriteLine($"End {Thread.CurrentThread.Name}, Threads running {RunningThreadsCount()}"); ;

        }

        //action with syncronization
        public void SyncAction()
        {
            mutex.WaitOne();

            Console.WriteLine($"Start {Thread.CurrentThread.Name}, Threads running {RunningThreadsCount()}");
            for (int i = 0; i < 50900; i++)
            {
                Console.Write("");
            }
            Console.WriteLine($"End {Thread.CurrentThread.Name}, Threads running {RunningThreadsCount()}"); ;

            mutex.ReleaseMutex();   
        }

        //action with pseudo activies
        public void ActionWithThreadSleep()
        {
            Console.WriteLine($"Start {Thread.CurrentThread.Name}, Threads running {RunningThreadsCount()}");
            Thread.Sleep(3000);
            Console.WriteLine($"End {Thread.CurrentThread.Name}, Threads running {RunningThreadsCount()}"); ;

        }
        
        //count running threads
        private int RunningThreadsCount()
        {
            using (var currentProcess = System.Diagnostics.Process.GetCurrentProcess())
            {
                return currentProcess.Threads
                    .OfType<System.Diagnostics.ProcessThread>()
                    .Where(t => t.ThreadState == System.Diagnostics.ThreadState.Running)
                    .Count();
            }
        }
    }
}
