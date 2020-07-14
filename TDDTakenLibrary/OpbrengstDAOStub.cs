using System;
using System.Collections.Generic;
using System.Text;

namespace TDDTakenLibrary
{
    public class OpbrengstDAOStub:IOpbrengstDAO
    {
        public decimal TotaleOpbrengst()
        {
            return 200m;
        }
    }
}
