using HairDresserApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private SalonDbContext dbContext { get; set; }
        public ClientController(SalonDbContext context)
        {
            this.dbContext = context;
        }

    }
}
