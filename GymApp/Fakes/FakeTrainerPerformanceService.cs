using GymApp.Models;
using GymApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Fakes
{
    public class FakeTrainerPerformanceService : ITrainerPerformanceService
    {
        private readonly PerformanceReport _performanceReport;

        public FakeTrainerPerformanceService(PerformanceReport performanceReport)
        {
            _performanceReport = performanceReport;
        }
        public PerformanceReport GetTrainerPerformanceReport(Guid trainerId)
        {
            throw new NotImplementedException();
        }
    }
}
