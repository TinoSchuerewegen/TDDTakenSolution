//using System;

namespace TDDTakenLibrary
{
    public class VeilingTextFixtures
    {
        private decimal hoogsteBod;

        public decimal HoogsteBod
        {
            get
            {
                return hoogsteBod;
            }
        }

        public void DoeBod(decimal bod)
        {
            if (bod > hoogsteBod)
            {
                hoogsteBod = bod;
            }
        }
    }
}