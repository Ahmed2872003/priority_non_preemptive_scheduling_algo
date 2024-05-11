using System.Collections.Generic;

namespace process_scheduling_algorithm.Models
{
    internal class Process
    {
        private static int counter = 0;
        public int id;
        public int burst_time;
        public int arrival_time;
        public int priority;
        public int completion_time;
        public int turn_around_time; // completionTime - arrivalTime
        public int waiting_time;  // turnAroundTime - burstTime
        public int response_time; // processGetCPU - arrival time

        public Process(int arrival_time, int burst_time, int priority)
        {
            id = counter++;
            this.burst_time = burst_time;
            this.arrival_time = arrival_time;
            this.priority = priority;
        }

        override
        public string ToString()
        {
            return "{ ID: " + id + ", Arrival_time: " + arrival_time + ", Burst_time: " + burst_time + ", Priority: " + priority + ", " + "Waiting_time: " + waiting_time + ", Turn_around_time: " + turn_around_time + ", Completion_time: " + completion_time + ", Response_time: " + response_time + " }";
        }

        public class Comparer : Comparer<Process>
        {
            public override int Compare(Process x, Process y)
            {
                int arrTCompare = x.arrival_time.CompareTo(y.arrival_time);
                int prioTCompare = x.priority.CompareTo(y.priority);
                int idCompare = x.id.CompareTo(y.id);

                if (arrTCompare == 0)
                    return prioTCompare != 0 ? prioTCompare : idCompare;
                else
                    return arrTCompare;
            }
        }

        public class Comparer2 : Comparer<Process>
        {
            public override int Compare(Process x, Process y)
            {
                int prioCompare = x.priority.CompareTo(y.priority);
                int arrCompare = x.arrival_time.CompareTo(y.arrival_time);
                int idCompare = x.id.CompareTo(y.id);


                if (prioCompare != 0) return prioCompare;
                else return arrCompare != 0 ? arrCompare : idCompare;
            }
        }
    }
}
