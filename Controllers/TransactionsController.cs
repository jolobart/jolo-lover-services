using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using JoloLoverServices.Interfaces;
using JoloLoverServices.WebModels;
using JoloLoverServices.Extension;

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
        public IActionResult Save([FromBody] CreateTransactionWebRequest webRequest)
        {
            _transactionService.Save(webRequest.ToRequest());
            return Ok();
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