using GymApp.Models;
using System;
using System.Collections.Generic;

namespace GymApp.Services
{
    public interface ITrainingService
    {
        List<Training> GetTrainingsInTheLastMonth(Guid trainerId);
    }
}
