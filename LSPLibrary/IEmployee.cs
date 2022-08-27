﻿namespace LSPLibrary
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }

        void CalculateHourlyRate(int rank);
    }
}