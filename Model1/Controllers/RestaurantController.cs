using Microsoft.AspNetCore.Mvc;
using Model1.Models;

[ApiController]
public class RestaurantController(MapDbContext db) : ControllerBase
{
    [HttpGet("system/api/restaurant/list")]
    public ApiResult List()
     {
        return ApiResult.Ok();
     }
}