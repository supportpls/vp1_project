using System;
using Common.Business_Objects;

namespace Common
{
	public interface ISpecialPlugin
	{
		bool CalculateSpecial (Booking booking, ref string specialName, ref decimal specialPrice);

	}
}

