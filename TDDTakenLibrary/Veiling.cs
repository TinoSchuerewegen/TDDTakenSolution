//using System;

namespace TDDTakenLibrary
{
    public class Veiling
    {
        private decimal hoogsteBod;

        public decimal HoogsteBod
        {
            get 
            {
                //throw new NotImplementedException();
                return hoogsteBod;
            }
        }

        public void DoeBod(decimal bod)
        {
            //throw new NotImplementedException();
            if (bod > hoogsteBod)
            {
                hoogsteBod = bod;
            }
        }
    }
}
