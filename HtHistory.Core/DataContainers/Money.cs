﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HtHistory.Core.DataContainers
{
    public class Currency
    {
        public string Name { get; private set; }
        public double Factor { get; private set; }

        public Currency(string name, double factor)
        {
            Name = name ?? string.Empty;
            Factor = factor;
        }

        public override string ToString()
        {
            return Name;
        }

        public static readonly Currency SEK = new Currency("SEK", 1.0);
        public static readonly Currency Euro = new Currency("€", 10.0);
        public static readonly Currency DollarsUS = new Currency("US $", 10.0);
        public static readonly Currency PesosARG = new Currency("Pesos ARG", 10.0);
        public static readonly Currency Yuan = new Currency("Yuan", 1.0);
        public static readonly Currency DKK = new Currency("DKK", 1.0);
        public static readonly Currency PoundsGB = new Currency("£", 15.0);
        public static readonly Currency SwissFrancs = new Currency("CHF", 5.0);
        public static readonly Currency Rand = new Currency("Rand", 1.25);
        public static readonly Currency Zloty = new Currency("zł", 2.5);
        public static readonly Currency Lei = new Currency("Lei", 0.5);
        public static readonly Currency ReaisBRA = new Currency("Reais BRA", 5.0);

        public static IEnumerable<Currency> GetAll()
        {
            foreach (var p in typeof(Currency).GetFields(  BindingFlags.Static |
                                                           BindingFlags.Public))
            {
                Currency c = p.GetValue(null) as Currency;
                if (null != c) yield return c;
            }
        }
    }

    public class Money : IComparable<Money>
    {
        public double Amount { get; private set; }
        public Currency Currency { get; private set; }

        public Money(double amount, Currency currency = null)
        {
            this.Currency = currency ?? Currency.SEK;
            this.Amount = amount;
        }

        //copy constructor
        public Money(Money rhs) : this(rhs.Amount, rhs.Currency)
        {
        }

        public override string ToString()
        {
            return String.Format("{0:0,0.} {1}", this.Amount, this.Currency.Name);
        }

        public int CompareTo(Money other)
        {
            return (int)((this.Currency.Factor * this.Amount) - (other.Currency.Factor * other.Amount)); 
        }

        public void ConvertTo(Currency newCurrency)
        {
            if (newCurrency == null) throw new ArgumentNullException("newCurrency");
            
            if (!Currency.Equals(newCurrency))
            {
                Amount = Amount * Currency.Factor / newCurrency.Factor;
                Currency = newCurrency;
            }
        }

        public static Money operator +(Money lhs, Money rhs)
        {
            return new Money(lhs.Amount + (rhs.Amount * rhs.Currency.Factor / lhs.Currency.Factor), lhs.Currency);
        }
        
        public static Money operator -(Money lhs, Money rhs)
        {
            return new Money(lhs.Amount - (rhs.Amount * rhs.Currency.Factor / lhs.Currency.Factor), lhs.Currency);
        }
    
    }
}
