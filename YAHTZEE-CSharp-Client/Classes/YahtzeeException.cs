using System;

namespace YAHTZEE_CSharp_Client.Classes
{
    class YahtzeeException : Exception
    {
        public YahtzeeException(string message) : base(message)
        {

        }
    }
}
