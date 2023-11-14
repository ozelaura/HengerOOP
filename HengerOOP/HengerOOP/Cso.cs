using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HengerOOP
{
    public class Cso:Henger
    {
        private int falVastagsag;

        public Cso(int falVastagsag)
        {
            this.falVastagsag = falVastagsag;
        }

        public int FalVastagsag { get => falVastagsag;}

        public void Cso()
        {
            throw new System.NotImplementedException();
        }

        public void Terfogat()
        {
            throw new System.NotImplementedException();
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}