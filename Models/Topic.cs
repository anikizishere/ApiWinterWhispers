using System.Text.Json.Serialization;

namespace ApiWinterWhispers.Models
{
    public class Topic
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        //public static List<Topic> GetTopics()
        //{
                        
        //    return new List<Topic>
        //    {
        //        new Topic {Id=1, Name = "Skidor" },
        //        new Topic {Id=2, Name = "Resa" },
        //        new Topic {Id=3, Name = "Annat" }
        //    };
        //}
    }
}
