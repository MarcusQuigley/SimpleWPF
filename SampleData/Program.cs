//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace SampleData
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Testing GetProcess");

//            GetProcesses process = new GetProcesses(1000);
//            process.ProcessList +=  process_ProcessList;

//            Console.WriteLine("Enter to quit");



//            while (true)
//            {
//                ConsoleKeyInfo key = Console.ReadKey();
//                if (key.Key == ConsoleKey.Enter)
//                {
//                    process.EndProcess = true;
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine(key.KeyChar);
//                }
//            }

//            Console.WriteLine("About to quit");
//          //  process.ProcessCount -= process_ProcessCount;
//             process = null;
//             GC.Collect();
//             GC.WaitForPendingFinalizers();
//             GC.Collect();
//            System.Threading.Thread.Sleep(2000);


            
//        }

//        static void process_ProcessList(List<System.Diagnostics.Process> processes)
//        {
//            Console.WriteLine("Process Count : {0}", processes.Count);
//        }

//        static void process_ProcessCount(int count)
//        {
//            Console.WriteLine("Process Count : {0}", count);
//        }
//    }
//}
