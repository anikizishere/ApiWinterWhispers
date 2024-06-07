using ApiWinterWhispers.DAL;
using Microsoft.AspNetCore.Mvc;

namespace ApiWinterWhispers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TopicsController : ControllerBase
    {
        private readonly TopicManager _topicManager;
        public TopicsController(TopicManager topicManager)
        {
            _topicManager = topicManager;
        }

        [HttpGet]
        public async Task<List<Models.Topic>> Get()
        {
            var topics = await _topicManager.GetTopics();
            return topics;
        }



        //[HttpPost]
        //public async Task Post([FromBody] Models.Topic topic)
        //{
        //    await _topicManager.AddTopic(topic);
        //}






        //[HttpGet]
        //public async Task<IEnumerable<Models.Topic>> GetTopicsAsync() //IEnumerable en lightare version av list
        //{
        //    return await DAL.TopicManager.GetAllTopics();
        //}
    }
}

