using GymApp.Models;
using System;

namespace GymApp.Services
{
    public interface IPaymentService
    {
        void UpdateTrainerBonusPayment(Guid trianerId, BonusPayment payment);
    }
}
