using Api.RequestHelpers;
using Core.Entities;
using Core.ISpetification;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected async Task<ActionResult> CreatePagedResult<T>(IGenericService<T> _service,
        ISpecification<T> spec, int pageIndex, int pageSize) where T : BaseEntity
        {
            var items = await _service.ListAsync(spec);
            var count = await _service.CountAsync(spec);

            var pagination = new Pagination<T>(pageIndex, pageSize, count, items);

            return Ok(pagination);
        }
    }
}
