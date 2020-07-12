using System;
using System.Linq;

namespace TDDTakenLibrary
{
    public class Palindroom
    {
        public string Woord { get; set; }

        public Palindroom (string invoer)
        {
            Woord = invoer;
        }

        public bool IsPalindroom()
        {
            var omgekeerdWoord = new string(Woord.ToArray().Reverse().ToArray());
            return Woord == omgekeerdWoord;
        }

        public bool IsPalindroom01()
        {
            for (var teller = 0; teller < Woord.Length / 2; teller++)
            {
                if (Woord[teller] != Woord[Woord.Length - 1 - teller]) return false;
            }
            return true;
        }

        public bool IsPalindroom02()
        {
            return Woord == new string(Woord.ToCharArray().Reverse().ToArray());
        }
    }
}
