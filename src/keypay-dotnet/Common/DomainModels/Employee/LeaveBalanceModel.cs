﻿namespace KeyPay.Common.DomainModels.Employee
{
    public class LeaveBalanceModel
    {
        public int LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal AccruedAmount { get; set; }
    }
}