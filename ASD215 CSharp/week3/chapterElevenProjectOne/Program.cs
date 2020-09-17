using System;

namespace chapterElevenProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null) throw new ArgumentNullException(nameof(args));

            BasketballTicket basketball = new BasketballTicket();
            Console.WriteLine(basketball);

            MusicalTicket musical = new MusicalTicket();
            Console.WriteLine(musical);

            PlayTicket play = new PlayTicket();
            Console.WriteLine(play);
        }
    }

}
