using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines_Ярыгин.Models;

namespace Airlines_Ярыгин.Classes
{
    public class TicketContext:Ticket
    {
        public static List<TicketContext> AllTicket()
        {
            List<TicketContext> allTickets = new List<TicketContext>();
            return allTickets;
        }
    }
}
