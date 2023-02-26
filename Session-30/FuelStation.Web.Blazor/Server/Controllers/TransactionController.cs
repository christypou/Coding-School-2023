using FuelStation.EF.Repositories;
using FuelStation.Model;

using FuelStation.Web.Blazor.Shared.Transaction;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class TransactionController : ControllerBase
	{
		private readonly IEntityRepo<Transaction> _transactionRepo;


		public TransactionController(IEntityRepo<Transaction> transactionRepo)
		{
			_transactionRepo = transactionRepo;
		}

		[HttpGet]
		public async Task<IEnumerable<TransactionListDto>> Get()
		{
			var result = _transactionRepo.GetAll();
			return result.Select(transaction => new TransactionListDto
			{
				Id = transaction.Id,
				Date= transaction.Date,
				CustomerId= transaction.Customer.Id,
				EmployeeId= transaction.Employee.Id,
				PaymentMethod = transaction.PaymentMethod,
				TotalValue= transaction.TotalValue,
				
				
			});
		}

		[HttpGet("{id}")]
		public async Task<TransactionEditDto> GetById(int id)
		{
			var result = _transactionRepo.GetById(id);
			return new TransactionEditDto
			{
				Id = id,
				Date = result.Date,
				CustomerId = result.CustomerId,
				EmployeeId = result.EmployeeId,
				PaymentMethod = result.PaymentMethod,
				TotalValue = result.TotalValue
			};
		}
		[HttpPost]
		public async Task Post(TransactionEditDto transaction)
		{
			var newTransaction = new Transaction(transaction.PaymentMethod, transaction.TotalValue);
			newTransaction.CustomerId = transaction.CustomerId;
			newTransaction.EmployeeId = transaction.EmployeeId;
			_transactionRepo.Add(newTransaction);
		}
		[HttpPut]
		public async Task Put(TransactionEditDto transaction)
		{
			var itemToUpdate = _transactionRepo.GetById(transaction.Id);
			itemToUpdate.PaymentMethod = transaction.PaymentMethod;
			itemToUpdate.CustomerId = transaction.CustomerId;
			itemToUpdate.EmployeeId = transaction.EmployeeId;
			itemToUpdate.TotalValue = transaction.TotalValue;
			_transactionRepo.Update(transaction.Id, itemToUpdate);
		}
		[HttpDelete("{id}")]
		public async Task Delete(int id)
		{
			_transactionRepo.Delete(id);
		}


	}
}
