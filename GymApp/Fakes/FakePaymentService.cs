using GymApp.Models;
using GymApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Fakes
{
    public class FakePaymentService : IPaymentService
    {
            public Dictionary<Guid, BonusPayment> UpdatedPayments { get; } = new();

            public void UpdateTrainerBonusPayment(Guid trainerId, BonusPayment payment)
            {
                
                UpdatedPayments[trainerId] = payment;
            }
        
    }
}
