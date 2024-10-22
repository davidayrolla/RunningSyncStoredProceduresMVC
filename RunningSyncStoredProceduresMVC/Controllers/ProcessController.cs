using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunningSyncStoredProceduresMVC.Context;
using System.ComponentModel;

namespace RunningSyncStoredProceduresMVC.Controllers
{
    public class ProcessController : Controller
    {

        private readonly AppDbContext _context;

        public ProcessController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Execute()
        {
            string taskName = "Task_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            var execute = await _context.ExecuteStoredProcedureAsync(taskName);

            if( execute == 0)
            {
                return StatusCode(500, "Error creating task.");
            }

            var process = await _context.Processes.FirstOrDefaultAsync(p => p.TaskName == taskName);

            return View(process);
        }

    }
}
