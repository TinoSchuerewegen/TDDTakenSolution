using System;
using System.Resources;
using System.Text.Json;

namespace TDDTakenLibrary
{
    public class ISBN
    {
        public const long MaxWaarde13Cijfers = 9999999999999L;
        public const long MinWaarde13Cijfers = 1000000000000L;
        private long nummer;

        public ISBN(long nummer)
        {
            //throw new NotImplementedException();
            if(nummer<MinWaarde13Cijfers || nummer > MaxWaarde13Cijfers)
            {
                throw new ArgumentException();
            }

            var somEvenCijfers = 0L;
            var somOnevenCijfers = 0L;
            var teVerwerkenCijfers = nummer / 10;

            for (int teller = 0; teller!=6; teller++)
            {
                somEvenCijfers += teVerwerkenCijfers % 10;   // je begint met 12 cijfers, je deelt dit door 10 om een cijfer na de 
                teVerwerkenCijfers /= 10;                    // komma te krijgen door restdeling toe te passen krijg je dit cijfer. En dan deel je het nummer door 10 
                somOnevenCijfers += teVerwerkenCijfers % 10; //om naar 11 cijfers te gaan, enz...
                teVerwerkenCijfers /= 10;
            }

            var controleGetal = somEvenCijfers * 3 + somOnevenCijfers; // om het controlegetal te verkrijgen doe je som even cijfers maal 3 + som oneven cijfers
            var naastGelegenHogerTiental = controleGetal - controleGetal % 10 + 10; // 138 - 8 (restdeling 10) + 10 geeft je het naast hoger gelegen tiental
            var verschil = naastGelegenHogerTiental - controleGetal;
            var laatsteCijfer = nummer % 10;

            if (verschil == 10)
            {
                if (laatsteCijfer != 0)
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                if (laatsteCijfer != verschil)
                {
                    throw new ArgumentException();
                }
            }
            this.nummer = nummer;
        }

        public override string ToString()
        {
            //throw new NotImplementedException();
            return nummer.ToString();
        }
    }
}
