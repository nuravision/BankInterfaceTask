
namespace Domain.Models
{
	public class Credit
	{
	

		Guid Id { get; set; }
		Client Client { get; set; }
		public decimal Amount { get; set; }
		public int Percent { get; set; }
		public int Months { get; set; }
		public decimal CalculatePercent { get; set; }
		public decimal Payment { get; set; }
		public Credit(Guid id, Client client, decimal amount, int percent, int months, decimal calculatePercent, decimal payment)
		{
			Id = id;
			Client = client;
			Amount = amount;
			Percent = percent;
			Months = months;
			CalculatePercent = calculatePercent;
			Payment = payment;
		}
	}
}
