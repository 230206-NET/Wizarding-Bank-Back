using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using DataAccess;
using DataAccess.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly Services.LoanServices _service;
        public LoanController(Services.LoanServices service) {
            _service = service;
        }

        [HttpGet("Info")]
        public List<Loan> GetAllBusinessUserLoan([FromQuery]int business_id) {
            return _service.GetAllBusinessLoan(business_id);
        }

        [HttpPost("New")]
        public Loan CreateLoan(Loan loan) {
            return _service.CreateBusinessLoan(loan);
        }

        [HttpPut("Pay")]
        public Loan PayBusinessLoan(Loan loan, int amount) {
            return _service.PayLoan(loan, amount);
        }
    }
}
