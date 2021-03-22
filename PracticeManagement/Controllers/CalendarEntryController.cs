using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeManagement.Models;
using PracticeManagement.Data;
//using Swashbuckle.AspNetCore.Annotations;

namespace PracticeManagement.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CalendarEntryController : ControllerBase
    {
        public readonly ApplicationDbContext _dbContext;
        public CalendarEntryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       // private readonly ILogger<CalendarDetailController> _logger;

        //public CalendarDetailController(ILogger<CalendarDetailController> logger)
        //{
        //    _logger = logger;
          
           
        //}


        [HttpGet]
        public ActionResult<List<CalendarEntry>> Get()
        {
            return _dbContext.CalendarEntries.ToList();
        }

        [HttpPost]
      
        public ActionResult

        //public IEnumerable<List<CalendarEntry>> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        [Route("{CaledndarId}")]
        //[SwaggerOperation(OperationId = "GetCodingEvent", Summary = "Retrieve Coding Event data")]
       // [SwaggerResponse(200, "Complete Coding Event data", Type = typeof(CodingEvent))]
      //  [SwaggerResponse(404, "Coding Event not found", Type = null)]
        public ActionResult GetUserCalendar([FromRoute] int Id)
        {
            var codingEvent = _dbContext.Calendars.Find(Id);
            if (codingEvent == null) return NotFound();

            return Ok(codingEvent);
        }

    }
}
