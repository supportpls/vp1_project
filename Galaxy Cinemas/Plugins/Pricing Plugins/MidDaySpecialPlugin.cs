using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Common;


namespace GalaxyCinemas
{


	public class MidDaySpecialPlugin : ISpecialPlugin
    {
        public bool CalculateSpecial(Booking booking, ref string specialName, ref decimal specialPrice)
        {
            TimeSpan timeOfDay = booking.SessionDate.TimeOfDay;
            // If not mid-day, not applicable.
            // If movie doesn't start between 11am and 1pm
			if((timeOfDay.CompareTo(TimeSpan(11,0,0))<0)||(timeOfDay.CompareTo(TimeSpan(11,0,0))>0))
			{
				return false;
			}
			else 
			{
	            // Calculate the discounted price that we would offer.
				decimal discountedPrice = booking.OriginalPrice*0.8;
				// If this discount is applicable, set specialName and specialPrice to our name and price.
				if (discountedPrice < booking.OriginalPrice) 
				{
					specialPrice = discountedPrice;
					specialName = "Mid-day Special";
					return true;
				}
				else 
				{
					return false;
				}
           }
    	}
	}
}