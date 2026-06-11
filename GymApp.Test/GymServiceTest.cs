using GymApp.Fakes;
using GymApp.Models;
using GymApp.Services;
using NUnit.Framework;
using System;

namespace GymApp.Test
{
    //Guid example: "00000000-0000-0000-0000-000000000001"
    [TestFixture]
    public class GymServiceTest
    {
        FakePaymentService _fakePaymentService;
        FakeTrainerPerformanceService _fakeTrainerPerformanceService;
        FakeTrainingService _fakeTrainingService;
        GymService _gymService;

        [TestCaseSource(typeof(PictParser), nameof(PictParser.GetTestCases))]
        public void GetMembershipType_PictTestCases_ReturnsExpectedResult(int numberOfMonths, bool groupTrainings, double monthlyPriceBudget, TrainingTime trainingTime, MembershipType membershipType)
        {
            _fakePaymentService = new FakePaymentService();

            
        }

        [SetUp]
        public void SetUp()
        {
            _fakeTrainerPerformanceService = new FakeTrainerPerformanceService();
            _fakeTrainingService = new FakeTrainingService();
            _fakePaymentService = ;
            _gymService = new GymService();



        }

        [Test]
        public void GetMemberhipType_TrainingOnlyMorning_ReturnTypeC()
        {
            //Arrange
            int numberOfMonths = 5;
            bool groupTrainings = false;
            double monthlyPriceBudget = 21;
            TrainingTime trainingTime = TrainingTime.WholeDay;

            //Act
            MembershipType membershipType = _gymService.GetMembershipType(numberOfMonths, groupTrainings, monthlyPriceBudget, trainingTime);

            //Assert
            Assert.That(membershipType, Is.EqualTo("TypeB"));
        }
        public void GetMemberhipType_TrainingTimeWholeDay_ReturnTypeA()
        {
            //Arrange
            int numberOfMonths = 5;
            bool groupTrainings = true;
            double monthlyPriceBudget = 21;
            TrainingTime trainingTime = TrainingTime.WholeDay;

            //Act
            MembershipType membershipType = _gymService.GetMembershipType(numberOfMonths, groupTrainings, monthlyPriceBudget, trainingTime);

            //Assert
            Assert.That(membershipType, Is.EqualTo("TypeA"));
        }
        public void GetMemberhipType_TrainingTimeWholeDayMonthly19_ReturnNull()
        {
            //Arrange
            int numberOfMonths = 5;
            bool groupTrainings = false;
            double monthlyPriceBudget = 19; 
            TrainingTime trainingTime = TrainingTime.WholeDay;

            //Act
            MembershipType membershipType = _gymService.GetMembershipType(numberOfMonths, groupTrainings, monthlyPriceBudget, trainingTime);

            //Assert
            Assert.That(membershipType, Is.EqualTo("Null"));
        }
        public void GetMemberhipType_TrainingTimeWholeDayMonthly20_ReturnNull()
        {
            //Arrange
            int numberOfMonths = 5;
            bool groupTrainings = false;
            double monthlyPriceBudget = 20;
            TrainingTime trainingTime = TrainingTime.WholeDay;

            //Act
            MembershipType membershipType = _gymService.GetMembershipType(numberOfMonths, groupTrainings, monthlyPriceBudget, trainingTime);

            //Assert
            Assert.That(membershipType, Is.EqualTo("Null"));
        }
        public void GetMemberhipType_TrainingTimeWholeDayNumOfMonths_ReturnNull()
        {
            //Arrange
            int numberOfMonths = 4;
            bool groupTrainings = false;
            double monthlyPriceBudget = 20;
            TrainingTime trainingTime = TrainingTime.WholeDay;

            //Act
            MembershipType membershipType = _gymService.GetMembershipType(numberOfMonths, groupTrainings, monthlyPriceBudget, trainingTime);

            //Assert
            Assert.That(membershipType, Is.EqualTo("Null"));
        }
        public void GetMemberhipType_TrainingTimeOnlyMorningMonths_ReturnTypeC()
        {
            //Arrange
            int numberOfMonths = 13;
            bool groupTrainings = false;
            double monthlyPriceBudget = 15;
            TrainingTime trainingTime = TrainingTime.WholeDay;

            //Act
            MembershipType membershipType = _gymService.GetMembershipType(numberOfMonths, groupTrainings, monthlyPriceBudget, trainingTime);

            //Assert
            Assert.That(membershipType, Is.EqualTo("TypeC"));
        }
        public void GetMemberhipType_TrainingTimeOnlyMorningBudget_ReturnTypeC()
        {
            //Arrange
            int numberOfMonths = 12;
            bool groupTrainings = false;
            double monthlyPriceBudget = 16;
            TrainingTime trainingTime = TrainingTime.WholeDay;

            //Act
            MembershipType membershipType = _gymService.GetMembershipType(numberOfMonths, groupTrainings, monthlyPriceBudget, trainingTime);

            //Assert
            Assert.That(membershipType, Is.EqualTo("TypeC"));
        }
        public void GetMemberhipType_TrainingTimeOnlyMorning_ReturnNull()
        {
            //Arrange
            int numberOfMonths = 10;
            bool groupTrainings = false;
            double monthlyPriceBudget = 15;
            TrainingTime trainingTime = TrainingTime.WholeDay;

            //Act
            MembershipType membershipType = _gymService.GetMembershipType(numberOfMonths, groupTrainings, monthlyPriceBudget, trainingTime);

            //Assert
            Assert.That(membershipType, Is.EqualTo("Null"));
        }

        public void DoStaffBonusPaymentCalculation_Bonus150()
        {


        }



    }
}
