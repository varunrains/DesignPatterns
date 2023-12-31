﻿using System.ComponentModel.DataAnnotations;

namespace InterfaceCustomer
{
    //Because of the shortcoming in the EF we are defining it as 
    //abstract class here, and you cannot create a object of abstract class
    //We are removing the abstract key word from here
    public class CustomerBase : ICustomer
    {

        public IValidation<ICustomer>? _customerValidation = null;
        private readonly IDiscount _discount = null;
        private readonly IExtraCharge _extraCharge = null;

        //Design pattern :- Memento pattern (Revert to old state)
        private ICustomer _oldCopy = null;

        public CustomerBase(IValidation<ICustomer> custValidation,
                            IDiscount discount,
                            IExtraCharge extraCharge)
        {
            _customerValidation = custValidation;
            _discount = discount;
            _extraCharge = extraCharge;
        }

        //For entity framework we need a primary key
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public string CustomerType { get; set; }

        public CustomerBase()
        {
            CustomerName = "";
            PhoneNumber = "";
            BillAmount = 0;
            BillDate = DateTime.Now;
            Address = "";
        }

        public  virtual void Validate()
        {
            _customerValidation?.Validate(this);
        }

        public void Clone()
        {
            if (_oldCopy == null)
            {
                //Memberwise clone is a Shallow copy and there is  a different implementation of deep copy
                // Design pattern : Prototype Pattern - It helps clone the object (Cloning)
                _oldCopy = (ICustomer)this.MemberwiseClone();
            }
        }

        //Design pattern :- Memento pattern (Revert to old state)
        public void Revert()
        {
            this.CustomerName = _oldCopy.CustomerName;
            this.Address = _oldCopy.Address;
            this.BillDate = _oldCopy.BillDate;
            this.BillAmount = _oldCopy.BillAmount;
            this.CustomerType = _oldCopy.CustomerType;
            this.PhoneNumber = _oldCopy.PhoneNumber;
        }

        public decimal ActualCost()
        {
           return (BillAmount - _discount.Calculate(this)) + _extraCharge.Calculate(this);
        }
    }
}
