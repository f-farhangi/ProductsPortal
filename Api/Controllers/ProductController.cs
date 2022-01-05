using Api.ApplicationServices;
using Api.Entities;
using Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Fields

        private readonly IProductService _service;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public ProductController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var entity= await _service.GetProducts();
            var dto = _mapper.Map<IEnumerable<ProductDto>>(entity);
            return Ok(dto);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(long id)
        {
            var entity = await _service.GetProduct(id);
            var dto = _mapper.Map<ProductDto>(entity);
            return Ok(dto);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductForInsertDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(modelState: ModelState);

            var product = _mapper.Map<Product>(dto);

            product.ProductPrices = new List<ProductPrice>
            {
                new ProductPrice
                {
                    Amount = dto.Amount,
                    StartDate = System.DateTime.Now
                }
            };

            await _service.InsertProduct(product);
            return Ok();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] ProductForUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(modelState: ModelState);

            var product = await _service.GetProduct(dto.Id);
            _mapper.Map(dto, product);

            var currentPrice = product.ProductPrices.FirstOrDefault(p => !p.EndDate.HasValue);
            currentPrice.EndDate = System.DateTime.Now;

            product.ProductPrices.Add(new ProductPrice()
            {
                Amount = dto.Amount,
                StartDate = System.DateTime.Now
            });

            await _service.UpdateProduct(product);
            return Ok();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            if (id <= 0)
                return BadRequest("Input Id Is Not Valid");

            await _service.DeleteProduct(id);
            return Ok();

        }

        #endregion
    }
}
