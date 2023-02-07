using Microsoft.AspNetCore.Mvc;
using JoloLoverServices.Interfaces;
using JoloLoverServices.WebModels.WalletWebModels;
using JoloLoverServices.Controllers.Extensions;
using JoloLoverServices.Controllers.Extensions.WalletControllerExtensions;

namespace JoloLoverServices.Controllers;

[ApiController]
[Route("[controller]")]
public class WalletsController : Controller
{
    private readonly IWalletService _walletService;

    public WalletsController(IWalletService walletService)
    {
        _walletService = walletService;
    }

    [HttpPost]
    public IActionResult UpsertWallet([FromBody] WalletWebRequest webRequest)
    {
        var response = _walletService.UpsertWallet(webRequest.ToRequest());
        return this.CreateResponse(response);
    }

    [HttpGet("{id}")]
    public IActionResult GetAllWallet([FromRoute] int id)
    {
        var response = _walletService.GetAll(id);
        return this.CreateResponse(response);
    }

    [HttpPost("{id}")]
    public IActionResult GetWalletById([FromBody] GetWalletWebRequest webRequest)
    {
        var response = _walletService.GetWalletById(webRequest.ToRequest());
        return this.CreateResponse(response);
    }

    [HttpDelete]
    public IActionResult RemoveWallet([FromBody] RemoveWalletWebRequest webRequest)
    {
        var response = _walletService.RemoveWallet(webRequest.ToRequest());
        return this.CreateResponse(response);
    }
}
