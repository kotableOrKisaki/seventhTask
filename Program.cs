using System;

namespace seventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesInHour = 60;
            int visitTimePerPerson = 10;
            int peopleCountInLine;
            int totalWaitingTime;
            int waitingHoursInLine;
            int waitingMinutesInLine;

            Console.Write("Сколько людей перед вами в очереди?\t");
            peopleCountInLine = Convert.ToInt32(Console.ReadLine());
            totalWaitingTime = visitTimePerPerson * peopleCountInLine;
            waitingHoursInLine = totalWaitingTime / minutesInHour;
            waitingMinutesInLine = totalWaitingTime % minutesInHour;

            Console.Write("Вам предстоит подождать {0} час(а) и {1} минут(ы)\n", waitingHoursInLine, waitingMinutesInLine);
        }
    }
}
