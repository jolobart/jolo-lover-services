using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using JoloLoverServices.Services;

namespace JoloLoverServices.Controllers
{
    public class TransactionsController : Controller
    {
        private TransactionService transactionService;
        public TransactionsController()
        {
            this.transactionService = new TransactionService();
        }

        JsonSerializerOptions seralizerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        [Route("transactions")]
        public IActionResult Index()
        {
            var transactionList = this.transactionService.GetAll();
            var payload = JsonSerializer.Serialize(transactionList, seralizerOptions);
            return Ok(payload);
        }

        [Route("transactions/{id}")]
        public IActionResult GetTransactionById(int id)
        {
            var transaction = this.transactionService.GetTransactionById(id);
            var payload = JsonSerializer.Serialize(transaction, seralizerOptions);
            return Ok(payload);
        }
    }
}