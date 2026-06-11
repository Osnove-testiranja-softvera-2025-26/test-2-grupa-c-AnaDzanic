using System;


namespace GymApp.Exceptions
{
    public class NoTrainingsInTheLastMonthException: Exception
    {
        public NoTrainingsInTheLastMonthException()
        {

        }

        public NoTrainingsInTheLastMonthException(string message): base(message)
        {

        }
    }
}
