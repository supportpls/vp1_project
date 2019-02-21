using System;

namespace Common
{
	public class Booking
	{
		public int BookingNumber {set;get;}
		public int SessionID {set;get;}
		public int Quantity {set;get;}
		public DateTime SessionDate {set;get;}
		public String Special { set; get;}
		public decimal Discount {set;get;}
		public decimal OriginalPrice {set;get;}
		public decimal FinalPrice {set;get;}




		public Booking ()
		{
			
		}
	}
}

