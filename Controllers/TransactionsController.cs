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
        public IActionResult GetAllTransactions([FromBody] GetAllTransactionWebRequest webRequest)
        {
            var response = _transactionService.GetAll(webRequest.ToRequest());
            return this.CreateResponse(response);
        }

        [HttpGet]
        public IActionResult GetTransactionById([FromBody] GetTransactionWebRequest webRequest)
        {
            var response = _transactionService.GetTransactionById(webRequest.ToRequest());
            return this.CreateResponse(response);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveTransaction([FromRoute] int id)
        {
            var response = _transactionService.RemoveTransaction(id);
            return this.CreateResponse(response);
        }
    }
}