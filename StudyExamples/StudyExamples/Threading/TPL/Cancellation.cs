using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudyExamples.Threading.TPL
{
    class Cancellation
    {
        static void Main(string[] args)
        {
            var list = Enumerable.Range(0, 10).ToArray();
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = cancellationTokenSource.Token;
            parallelOptions.MaxDegreeOfParallelism = System.Environment.ProcessorCount;

            Console.WriteLine("write 'x' to cancel");
            Task.Factory.StartNew(() =>
                {
                    if (Console.ReadKey().KeyChar == 'x')
                    {
                        cancellationTokenSource.Cancel();
                    }
                });
            Parallel.For<long>(0,list.Length,parallelOptions,
        }
    }
}
