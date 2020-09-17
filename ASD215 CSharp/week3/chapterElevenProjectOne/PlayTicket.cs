using System.Collections.Generic;

namespace chapterElevenProjectOne
{
    public class PlayTicket : Ticket
    {
        public List<string> Actors { get; set; }
        public PlayTicket()
        {
            Actors = new List<string>()
            {
                "Joel Byron", "Pamala Harrison", "Darnel Trumpet", "Micah Pants"
            };
        }

        public override string ToString()
        {
            return "Your ticket to see " + string.Join(", ", Actors).ToString() +
                " at " + EventDate + " is confirmed.";
        }
    }

}
