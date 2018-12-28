using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheTeams
{
    class InputVerification
    {

        // Name has to be a non-empty String. 
        public bool VerifyName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            return true; 
        }

        // Phone number has to be a 10-digit number or +46 and then nine more digits
        public bool VerifyPhoneNumber(string number)
        {
            if (string.IsNullOrEmpty(number)) return false; 
            if (number.StartsWith("+"))
            {
                if (number.Length != 12) return false;
                number = number.Substring(1); // remove +
                if (number.Substring(0, 2) != "46") return false;
            }
            else if (number.Length != 10) return false; 
            return int.TryParse(number, out int result); 
        }

        // Checking whether a particular string is a valid representation of an e-mail address, 
        // not whether an e-mail address is a valid destination to send a message.
        public bool VerifyEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool VerifyNumber(string number)
        {
            return int.TryParse(number, out int result);
        }

        // team size is from 5 to 8 (three subs)
        public bool VerifyIfTeamSizeIsValid(Player[] players)
        {
            if (players.Length < 5 || players.Length > 8)
            {
                return false;
            }
            else
                return true; 
        }

        // since a game consists of two teams, this is true if there are 10-16 players
        public bool VerifyIfNumberOfPlayersIsValid(Player[] players)
        {
            if (players.Length < 10 || players.Length > 16)
            {
                return false;
            }
            else
                return true;
        }
    }
}
