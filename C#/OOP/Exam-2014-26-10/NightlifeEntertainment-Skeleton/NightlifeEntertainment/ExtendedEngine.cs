namespace NightlifeEntertainment
{
    using System;
    using System.Linq;
    using System.Text;

    public class ExtendedEngine : CinemaEngine
    {
        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "cinema":
                    base.ExecuteInsertVenueCommand(commandWords);
                    break;
                case "opera":
                    var opera = new OperaHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sport_hall":
                    var sportHall = new SportHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(sportHall);
                    break;
                case "concert_hall":
                    var concerHall = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(concerHall);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[5]);

            switch (commandWords[2])
            {
                case "movie":
                    base.ExecuteInsertPerformanceCommand(commandWords);
                    break;
                case "theatre":
                    var theatre = new Theatre(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(theatre);
                    break;
                case "concert":
                    var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(concert);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteSellTicketCommand(string[] commandWords)
        {
            var performance = this.GetPerformance(commandWords[1]);
            var type = (TicketType)Enum.Parse(typeof(TicketType), commandWords[2], true);
            // this.output.Append(performance.SellTicket(type));
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            string searchedIndex = commandWords[1].ToLower();
            string name = string.Empty;
            string venue = string.Empty;
            string date = string.Empty;
            int seat = 0;
            decimal price = 0m;

            foreach (var performance in this.Performances)
            {
                if (performance.Name.ToLower().Contains(searchedIndex))
                {
                    //TODO Imlement method printing all sold tickets with ticket.ToString();

                    //int limit = performance.Tickets.Count - ; 

                    //for (int i = 0; i < UPPER; i++)
                    //{
                        
                    // 
                    //}


                }
            }
        }

        protected virtual void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "regular":
                    base.ExecuteSupplyTicketsCommand(commandWords);
                    break;
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }

                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VIPTicket(performance));
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
