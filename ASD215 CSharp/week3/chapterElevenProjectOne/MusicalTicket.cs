using System.Collections.Generic;

namespace chapterElevenProjectOne
{
    public class MusicalTicket : Ticket
    {
        public List<string> Musicians { get; set; }
        public MusicalTicket()
        {
            Musicians = new List<string>()
            {
                "Aesop Rock", "Hail Mary Mallon", "The Uncluded", "Malibu Ken"
            };
        }

        public override string ToString()
        {
            return "Your ticket to see " + string.Join(", ", Musicians).ToString() +
                " at " + EventDate + " is confirmed.";
        }
    }

}
