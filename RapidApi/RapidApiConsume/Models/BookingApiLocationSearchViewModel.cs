namespace RapidApiConsume.Models
{
    public class BookingApiLocationSearchViewModel
    {
            public bool status { get; set; }
            public string message { get; set; }
            public long timestamp { get; set; }
            public Datum[] data { get; set; }

        public class Datum
        {
            public string dest_id { get; set; }
        }

    }
}
