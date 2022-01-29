using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SearchApi.ApplicationServices;
using SearchApi.Entities;
using SearchApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SearchApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchDataController : ControllerBase
    {
        #region Fields

        private readonly ISearchDataService _service;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public SearchDataController(ISearchDataService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        // POST api/<SearchDataController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SearchDataForInsertDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(modelState: ModelState);

            var data = _mapper.Map<SearchData>(dto);

            await _service.InsertData(data);
            return Ok();
        }

        #endregion
    }
}
