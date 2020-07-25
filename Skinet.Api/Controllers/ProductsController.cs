using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skinet.Core.Entities;
using Skinet.Infrastructure.Data;

namespace Skinet.Api.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class ProductsController : ControllerBase {

        #region Private Members
        private readonly StoreContext _context;

        #endregion

        #region Constructors

        public ProductsController (StoreContext context) {
            _context = context;
        }

        #endregion

        #region Api

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts () 
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet ("{id}")]
        public async Task<ActionResult<Product>> GetProduct (int id) 
        {
            return await _context.Products.FindAsync(id);
        }

        #endregion
    }
}