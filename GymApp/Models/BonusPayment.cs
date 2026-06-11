using System;

namespace GymApp.Models
{
    public class BonusPayment
    {
        public Guid TrainerId { get; set; }
        public DateTime CalculationDate { get; set; }
        public double Amount { get; set; }

    }
}
