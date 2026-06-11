using GymApp.Models;
using System;
using System.Collections.Generic;

namespace GymApp.Services
{
    public interface ITrainerPerformanceService
    {
        PerformanceReport GetTrainerPerformanceReport(Guid trainerId);
    }
}
