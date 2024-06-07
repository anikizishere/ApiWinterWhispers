using Microsoft.EntityFrameworkCore;
namespace ApiWinterWhispers.DAL
{
    public  class TopicManager
    {

        private readonly MyDBContext _context;

        public TopicManager(MyDBContext context)
        {
            _context = context;
        }

        public async Task<List<Models.Topic>> GetTopics()
        {
            
            List<Models.Topic> topics = await _context.Topic.ToListAsync();

            Console.WriteLine("Här finns " + topics.Count + " att läsa om.");

            return topics;
        }


        //public static List<Models.Topic> Topics { get; set; }


        //public static async Task<List<Models.Topic>> GetAllTopics()
        //{
        //    if (Topics == null || !Topics.Any())
        //    {
        //        Topics = await TopicData.GetTopics(); // Från databas, annat api eller hårdkodad data
        //    }

        //    return Topics;
        //}

    }
}
