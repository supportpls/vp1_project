using System;

namespace Common
{
	public interface ISpecialPlugin
	{
		Boolean CalculateSpecial (Booking inputBooking, ref string specialName, ref decimal specialPrice);

	}
}

