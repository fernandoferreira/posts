using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//#nullable enable

namespace AsyncStreams
{
    class Program
    {

        //private async static IAsyncEnumerable<int> GetHeartBeatAsync()
        //{
        //    await Task.Delay(3000);
        //    Console.WriteLine($"Last check: {DateTime.Now}");
        //    yield return new Random().Next(40, 250);
        //}

        private static IEnumerable<int> GetHeartBeat()
        {
            Console.WriteLine($"Last check: {DateTime.Now}");
            yield return new Random().Next(40, 250);
        }


        //private async static void ShowHeartBeatAsync()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {

        //        await foreach (var item in GetHeartBeat())
        //        {
        //            Console.WriteLine($"Current heart beat: {item}\n");
        //        }
        //    }
        //}

        private static void ShowHeartBeat()
        {
            for (int i = 0; i < 5; i++)
            {

                 foreach (var item in GetHeartBeat())
                {
                    Console.WriteLine($"Current heart beat: {item}\n");
                }
            }
        }

        static void Main(string[] args)
        {
            ShowHeartBeat();
        }
    }
}
