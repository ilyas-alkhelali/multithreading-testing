
namespace ConsoleApp1
{
    public class ThreadsInf
    {
        public void GetMaxes()
        {
            ThreadPool.GetMaxThreads(out int nWorkerThreads, out int nCompletionThreads);
            ThreadPool.GetAvailableThreads(out int worker, out int io);

            Console.WriteLine("Max amount of threads in ThreadPool: " + nWorkerThreads
                + "\nThreads of read-write are accessible: " + nCompletionThreads);

            Console.WriteLine("Thread pool threads available at startup: ");
            Console.WriteLine("   Worker threads: {0:N0}", worker);
            Console.WriteLine("   Asynchronous I/O threads: {0:N0}", io);
        }
    }
}
