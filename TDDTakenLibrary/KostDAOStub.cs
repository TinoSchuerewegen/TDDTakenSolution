using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TDDTakenLibrary
{
    public class KostDAOStub:IKostDAO
    {
        public decimal TotaleKost()
        {
            return 169m;
        }
    }
}
