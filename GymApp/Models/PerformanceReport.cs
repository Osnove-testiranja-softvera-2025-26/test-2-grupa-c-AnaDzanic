using System;


namespace GymApp.Models
{

    public enum PerformanceRank
    {
        First,
        Second,
        Third
    }

    public class PerformanceReport
    {
        public int PercentOfTrainingsNotHeld { get; set; }
        public PerformanceRank PerformanceRank { get; set; }
        public int NumberOfFreeDaysLeft { get; set; }
    }
}
