﻿namespace ClearBank.DeveloperTest.Types
{
    public class Account
    {
        public string AccountNumber { get; set; }

        public AllowedPaymentSchemes AllowedPaymentSchemes { get; set; }

        public decimal Balance { get; set; }

        public AccountStatus Status { get; set; }
    }
}