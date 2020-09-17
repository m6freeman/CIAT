using System;

namespace chapterElevenProjectOne
{
    public abstract class Ticket
    {
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public double Price { get; set; }
        protected Ticket()
        {
            EventDate = DateTime.Today;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
