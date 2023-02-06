using Microsoft.AspNetCore.Mvc;
using JoloLoverServices.Interfaces;
using JoloLoverServices.WebModels.TransactionWebModels;
using JoloLoverServices.Controllers.Extensions;
using JoloLoverServices.Controllers.Extensions.TransactionControllerExtensions;

namespace JoloLoverServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : Controller
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        public IActionResult UpsertTransaction([FromBody] CreateTransactionWebRequest webRequest)
        {
            var response = _transactionService.UpsertTransaction(webRequest.ToRequest());
            return this.CreateResponse(response);
        }

        [HttpPost("list")]
        public IActionResult Index([FromBody] GetTransactionWebRequest webRequest)
        {
            var response = _transactionService.GetAll(webRequest.ToRequest());
            return this.CreateResponse(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetTransactionById([FromBody] GetTransactionWebRequest webRequest)
        {
            var response = _transactionService.GetTransactionById(webRequest.ToRequest());
            return this.CreateResponse(response);
        }

        [HttpDelete]
        public IActionResult RemoveTransaction([FromBody] RemoveTransactionWebRequest webRequest)
        {
            var response = _transactionService.RemoveTransaction(webRequest.ToRequest());
            return this.CreateResponse(response);
        }
    }
}