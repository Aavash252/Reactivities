using Domain;
using API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class ActivitiesController:BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context=context;
            
        }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>>GetActivities(){

            return await _context.Activities.ToListAsync();

        }

        [HttpGet("{id}")] //api/activities/id

        public async Task<ActionResult<Activity>>GerActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }


    }
}
 