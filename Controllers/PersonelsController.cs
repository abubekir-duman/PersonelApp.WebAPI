using Microsoft.AspNetCore.Mvc;
using PersonelApp.WebAPI.DTOs;
using PersonelApp.WebAPI.Filters;
using PersonelApp.WebAPI.Services;

namespace PersonelApp.WebAPI.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
//[MyAuthorize]
public sealed class PersonelsController(IPersonelService personelService) : ControllerBase
{
    [HttpGet]
    //[MyAuthorize]
    public IActionResult GetAll(int pageNumber=1)
    {
        var personels = personelService.GetAll(pageNumber);
        return Ok(personels);
    }

    [HttpPost]
    //[MyAuthorize]
    public IActionResult Create(CreatePersonelDto request)
    {
        var result = personelService.Create(request);
        if (!result) return BadRequest(new {Message="something went wrong"});
        return Ok(new { Message = "Personel create is successful" });
       
        
    }
}
