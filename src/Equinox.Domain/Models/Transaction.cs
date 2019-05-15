using Equinox.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Equinox.Domain.Models
{
    public class Transaction : Entity
    {

        public Transaction(Guid id, string transactionReference,Type type, double amount, double balance, string description)
        {
            Id = id;
            TransactionReference = transactionReference;
            Amount = amount;
            Balance = balance;
            Description = description;
            Type = type;
        }

        // Empty constructor for EF
        protected Transaction() { }

        public string TransactionReference { get; private set; }

        public Type Type { get; private set; }
        public double Amount { get; private set; }
        public double Balance { get; private set; }
        public string Description { get; private set; }
    }
    public enum Type { Credit, Debit };
}
