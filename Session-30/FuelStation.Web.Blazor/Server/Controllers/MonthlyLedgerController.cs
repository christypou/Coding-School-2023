using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.Transaction;
using FuelStation.Web.Blazor.Shared.TransactionLine;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class MonthlyLedgerController : Controller
	{
		private readonly IEntityRepo<Transaction> _transactionRepo;
		private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
		public MonthlyLedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<TransactionLine> transactionLineRepo)
		{
			_transactionRepo = transactionRepo;
			_transactionLineRepo = transactionLineRepo;
		}
		[HttpGet]
		public async Task<IEnumerable<TransactionListDto>> Get()
		{
			var result = _transactionRepo.GetAll();
			var transactionLines = _transactionLineRepo.GetAll();
			return result.Select(transaction => new TransactionListDto
			{
				Id = transaction.Id,
				Date = transaction.Date,
				CustomerId = transaction.Customer.Id,
				EmployeeId = transaction.Employee.Id,
				PaymentMethod = transaction.PaymentMethod,
				TotalValue = transaction.TotalValue,
				TransactionLines = transactionLines
					.Where(l => l.TransactionId == transaction.Id)
					.Select(l => new TransactionLineListDto
					{
						Id = l.Id,
						TransactionId = l.TransactionId,
						ItemId = l.ItemId,
						Quantity = l.Quantity,
						ItemPrice = l.ItemPrice,
						NetValue = l.NetValue,
						DiscountPercent = l.DiscountPercent,
						DiscountValue = l.DiscountValue,
						TotalValue = l.TotalValue,
						ItemCost = l.Item.Cost
					}).ToList()
			});
		}

	}
}
