using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCard
{
    class CreditCard
    {
        private string cardNo;
        private string name;
        private string expireDate;
        private int cvv;

        public CreditCard(string cardNo, string name, string expireDate, int cvv)
        {
            this.cardNo = cardNo;
            this.name = name;
            this.expireDate = expireDate;
            this.cvv = cvv;
            

        }
        public CreditCard() { }           
        
        public string CardNo
        {
            get
            {
                return this.cardNo;
            }
            set
            {
                this.cardNo = value;
            }

        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string ExpireDate
        {
            get
            {
                return this.expireDate;
            }
            set
            {
                this.expireDate = value;
            }
        }
        public int Cvv
        {
            get
            {
                return this.cvv;
            }
            set
            {
                this.cvv = value;
            }
        }
    }
    
}
