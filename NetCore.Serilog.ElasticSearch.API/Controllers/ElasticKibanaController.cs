using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCore.Serilog.ElasticSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElasticKibanaController : ControllerBase
    {
        private readonly ILogger<ElasticKibanaController> _logger;
        public ElasticKibanaController(ILogger<ElasticKibanaController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            _logger.LogInformation("ElasticKibana contoller GetAll data action...",DateTime.UtcNow);
            try
            {
                throw new Exception("Bad code!");
            }
            catch (Exception e)
            {
                _logger.LogError("Unknown error occured on the Get action of the ElasticKibana controller",DateTime.UtcNow);
            }

            return new string[] { "value1", "value2" };
        }

        
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            _logger.LogInformation("ElasticKibana contoller GetById data action...", DateTime.UtcNow);
            try
            {
                throw new Exception("Bad code!");
            }
            catch (Exception e)
            {
                _logger.LogError("Unknown error occured on the Get action of the ElasticKibana controller");
            }

            return "value";
        }

    }
}
