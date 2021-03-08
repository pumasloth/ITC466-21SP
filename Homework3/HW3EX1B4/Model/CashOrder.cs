using System;

namespace HW3EX1B4.Model
{
    /// <summary>
    /// The cash order class.
    /// Cash Transactions don’t need credit card processing.
    /// Point of Sale (POS) transactions don’t need inventory reservations.
    /// POS transactions don’t need email notifications.
    /// </summary>
    public class CashOrder : Order
    {
        // Cash transaction.
    }
}
