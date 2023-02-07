using Microsoft.AspNetCore.Mvc;
using JoloLoverServices.Interfaces;
using JoloLoverServices.WebModels.CategoryWebModels;
using JoloLoverServices.Controllers.Extensions;
using JoloLoverServices.Controllers.Extensions.CategoryControllerExtensions;

namespace JoloLoverServices.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriesController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost]
    public IActionResult UpsertCategories([FromBody] CategoryWebRequest webRequest)
    {
        var response = _categoryService.UpsertCategory(webRequest.ToRequest());
        return this.CreateResponse(response);
    }

    [HttpPost("{id}")]
    public IActionResult Index([FromRoute] int id)
    {
        var response = _categoryService.GetAll(id);
        return this.CreateResponse(response);
    }

    [HttpGet("{id}")]
    public IActionResult GetCategoryById([FromBody] GetCategoryWebRequest webRequest)
    {
        var response = _categoryService.GetCategoryById(webRequest.ToRequest());
        return this.CreateResponse(response);
    }

    [HttpDelete]
    public IActionResult RemoveCategory([FromBody] RemoveCategoryWebRequest webRequest)
    {
        var response = _categoryService.RemoveCategory(webRequest.ToRequest());
        return this.CreateResponse(response);
    }
}
