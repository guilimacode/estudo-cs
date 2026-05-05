using System.Diagnostics;

namespace CancellationToken
{
    internal class Program
    {
        private static CancellationTokenSource cancellationTokenSource;
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                cancellationTokenSource = new CancellationTokenSource();
            }
            catch (Exception)
            {

                Console.WriteLine("Tarefa cancelada");
            }
        }



        private static Task<int> OperacaoLongaDuracaoCancelavel(int valor, CancellationToken cancellationToken = default)
        {
            Console.WriteLine("Executou operação de longa duração");

            Task<int> task = null;

            task = Task.Run(() =>
            {
                int resultado = 0;
                for (int i = 0; i < valor; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                        throw new TaskCanceledException(task);

                    Thread.Sleep(50);
                    resultado += 1;
                }
                return resultado;
            });
            return task;
        }

    }
}
