﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TDDTakenLibrary
{
    public class WinstService
    {
        private readonly IOpbrengstDAO opbrengstDAO;
        private readonly IKostDAO kostDAO;

        public WinstService(IOpbrengstDAO opbrengstDAO, IKostDAO kostDAO)
        {
            this.opbrengstDAO = opbrengstDAO;
            this.kostDAO = kostDAO;
        }

        public decimal Winst
        {
            get
            {
                //throw new NotImplementedException();
                return opbrengstDAO.TotaleOpbrengst() - kostDAO.TotaleKost();
            }
        }
    }
}
