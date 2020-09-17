using System.Collections.Generic;

namespace chapterElevenProjectOne
{
    public class BasketballTicket : Ticket
    {
        public List<string> Teams { get; set; }
        public BasketballTicket()
        {
            Teams = new List<string>()
            {
                "Lakers", "Clippers"
            };
        }

        public override string ToString()
        {
            return "Your ticket to see " + string.Join(" vs ", Teams).ToString() +
                " at " + EventDate + " is confirmed.";
        }
    }

}
