using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.Transaction;
using FuelStation.Web.Blazor.Shared.TransactionLine;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class TransactionLineController : ControllerBase
	{
		private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
		public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo)
		{
			_transactionLineRepo = transactionLineRepo;
		}
		[HttpGet]
		public async Task<IEnumerable<TransactionLineListDto>> Get()
		{
			var result = _transactionLineRepo.GetAll();
			return result.Select(transactionLine => new TransactionLineListDto
			{
				Id = transactionLine.Id,
				TransactionId = transactionLine.Transaction.Id,
				ItemId= transactionLine.Item.Id,
				Quantity=transactionLine.Quantity,
				ItemPrice=transactionLine.ItemPrice,
				NetValue=transactionLine.NetValue,
				DiscountPercent=transactionLine.DiscountPercent,
				DiscountValue=transactionLine.DiscountValue,
				TotalValue = transactionLine.TotalValue
			});
		}
		[HttpGet("{id}")]
		public async Task<TransactionLineEditDto> GetById(int id)
		{
			var result = _transactionLineRepo.GetById(id);
			return new TransactionLineEditDto
			{
				Id = id,
				TransactionId= result.Transaction.Id,
				ItemId= result.Item.Id,
				Quantity = result.Quantity,
				ItemPrice= result.ItemPrice,
				NetValue=result.NetValue,
				DiscountValue=result.DiscountValue,
				DiscountPercent=result.DiscountPercent,
				TotalValue = result.TotalValue
			};
		}
		[HttpPost]
		public async Task Post(TransactionLineEditDto transactionLine)
		{
			var newTransactionLine = new TransactionLine(transactionLine.Quantity,transactionLine.ItemPrice,transactionLine.DiscountPercent);
			newTransactionLine.TransactionId = transactionLine.TransactionId;
			newTransactionLine.ItemId = transactionLine.ItemId;
			_transactionLineRepo.Add(newTransactionLine);
		}

		[HttpPut]
		public async Task Put(TransactionLineEditDto transactionLine)
		{
			var itemToUpdate = _transactionLineRepo.GetById(transactionLine.Id);
			itemToUpdate.ItemPrice = transactionLine.ItemPrice;
			itemToUpdate.NetValue = transactionLine.NetValue;
			itemToUpdate.DiscountPercent = transactionLine.DiscountPercent;
			itemToUpdate.DiscountValue = transactionLine.DiscountValue;
			itemToUpdate.TotalValue = transactionLine.TotalValue;
			itemToUpdate.NetValue = transactionLine.NetValue;
			itemToUpdate.ItemId= transactionLine.ItemId;
			itemToUpdate.Quantity= transactionLine.Quantity;
			itemToUpdate.TransactionId= transactionLine.TransactionId;
			_transactionLineRepo.Update(transactionLine.Id, itemToUpdate);
		}
		[HttpDelete("{id}")]
		public async Task Delete(int id)
		{
			_transactionLineRepo.Delete(id);
		}
	}
}
