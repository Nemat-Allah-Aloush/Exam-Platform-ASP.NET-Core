using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using GroupC.Uni.Core.Interfaces;
using GroupC.Uni.Core.Entities;
using System;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace GroupC.Uni.Api.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionsController : ControllerBase
    {
        private readonly ISubmissionService _context;

        public SubmissionsController(ISubmissionService context)
        {
            _context = context;

            if (_context.ListAllAsync() == null)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.AddAsync(new Submission { ExamId = new Guid() });

            }
        }


        [EnableCors("AllowMyOrigin")]
        // GET: api/Submissions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Submission>>> GetSubmissions()
        {
            var x = new List<Submission>( await _context.ListAllAsyncNoReadOnly());
            return x;
        }

        // GET: api/Submission/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Submission>> GetSubmission(Guid id)
        {
            var submission = await _context.getByIdWithAll(id);
            if (submission == null)
            {
                return NotFound();
            }
            return submission;
        }


        [HttpPost]
        public async Task<ActionResult<Submission>> PostSubmission(Submission submission)
        {
            await _context.CreateSubmissionAsync(submission);
            return CreatedAtAction(nameof(GetSubmission), new { id = submission.Id }, submission);
        }
    }
}
