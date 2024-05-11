using DotNetty.Common.Utilities;
using process_scheduling_algorithm.Models;
using System;
using System.Collections.Generic;


namespace process_scheduling_algorithm
{

    internal class Scheduling_Algo
    {


        public enum Type { Preemptive, NonPreemptive };

        public class Result
        {
            public float AVG_wating_T;
            public float AVG_turn_around_T;
            public float AVG_responce_T;

            override
            public string ToString()
            {
                return "{ " + "AVG_Waiting_T: " + AVG_wating_T + ", " + "AVG_turn_around_T: " + AVG_turn_around_T + ", AVG_response_T: " + AVG_responce_T + " }";
            }
        }

        public static Result Priority(ref List<Process> processes, Type t)
        {

            switch (t)
            {
                case Type.Preemptive:
                    return null;
                default:
                    return Priority_non_preemptive(ref processes);
            }
        }

        private static Result Priority_non_preemptive(ref List<Process> processes)
        {

            Result res = new Result();

            processes = Priority_non_preemptive_sort(processes);

            CalcProcessInfo(processes);

            CalcAVGS(processes, res);

            return res;
        }

        private static List<Process> Priority_non_preemptive_sort(List<Process> processes)
        {
            // compare according to priority only
            PriorityQueue<Process> pq = new PriorityQueue<Process>(new Process.Comparer2());

            // sort according to arrival & priority
            processes.Sort(new Process.Comparer());

            List<Process> sortedProcesses = new List<Process>();

            while (processes.Count != 0)
            {
                Process currProcess = processes[0];

                sortedProcesses.Add(currProcess);

                processes.RemoveAt(0);

                for (int j = 0; j < processes.Count; j++)
                {
                    if (processes[j].arrival_time <= currProcess.burst_time)
                    {

                        pq.Enqueue(processes[j]);

                        processes.RemoveAt(j);

                        j--;
                    }
                }

                while (pq.Count != 0) sortedProcesses.Add(pq.Dequeue());
            }
            return sortedProcesses;
        }

        private static void CalcProcessInfo(List<Process> processes)
        {
            int completionTime = 0;
            int firstGetCPUTime = 0;

            foreach (Process process in processes)
            {
                completionTime += process.burst_time;

                process.completion_time = completionTime;

                process.turn_around_time += completionTime - process.arrival_time;

                process.waiting_time = process.turn_around_time - process.burst_time;

                firstGetCPUTime = completionTime - process.burst_time;

                process.response_time = firstGetCPUTime - process.arrival_time;


            }
        }

        private static void CalcAVGS(List<Process> processes, Result res)
        {
            float sumWaitingTime = 0.0f;
            float sumTurnAroundTime = 0.0f;
            float sumResponseTime = 0.0f;

            foreach (Process process in processes)
            {
                sumWaitingTime += process.waiting_time;
                sumTurnAroundTime += process.turn_around_time;
                sumResponseTime += process.response_time;
            }

            res.AVG_wating_T = (float)Math.Round(sumWaitingTime / processes.Count, 2);

            res.AVG_turn_around_T = (float)Math.Round(sumTurnAroundTime / processes.Count);

            res.AVG_responce_T = (float)Math.Round(sumResponseTime / processes.Count, 2);

        }
    }



}
