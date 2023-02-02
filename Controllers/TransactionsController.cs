using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using JoloLoverServices.Interfaces;
using JoloLoverServices.Models;

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

        [HttpPost("")]
        public IActionResult Save([FromBody] object payload)
        {
            Console.WriteLine(payload);
            Console.Write("POSTTTT");
            Transaction hash = JsonSerializer.Deserialize<Transaction>(payload.ToString());

            // int id = int.Parse(hash["id"].ToString());
            // int userId = int.Parse(hash["userId"].ToString());
            // int walletId = int.Parse(hash["walletId"].ToString());
            // float amount = float.Parse(hash["amount"].ToString());
            // int categoryId = int.Parse(hash["categoryId"].ToString());
            // string note = hash["notes"].ToString();
            // string date = hash["dateTime"].ToString();

            // var transaction = new Transaction(id, userId, walletId, categoryId, amount, note, date);

            _transactionService.Save(hash);

            Dictionary<string, object> message = new Dictionary<string, object>();
            message.Add("message", "Ok");
            return Ok(message);
        }

        JsonSerializerOptions seralizerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        [HttpGet("")]
        public IActionResult Index()
        {
            var transactionList = _transactionService.GetAll();
            var payload = JsonSerializer.Serialize(transactionList, seralizerOptions);
            return Ok(payload);
        }

        [HttpGet("{id}")]
        public IActionResult GetTransactionById(int id)
        {
            var transaction = _transactionService.GetTransactionById(id);
            var payload = JsonSerializer.Serialize(transaction, seralizerOptions);
            return Ok(payload);
        }
    }
}