using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxyCinemas
{
    public class ImportResult
    {
		public int TotalRows { set; get;}
		public int ImportedRows{ set; get;}
		public int FailedRows{ set; get;}
		private List<String> errorMessages {set;get;}


		
		public List<String> ErrorMessages 
		{
			get 
			{
				return errorMessages;
			}
		}
       /*constructor 2*/
		public ImportResult(){
			TotalRows = 0;
			ImportedRows = 0;
			FailedRows = 0;
            if (errorMessages != null)
            {
                errorMessages.Clear();
            }
            else
            {
                errorMessages = new List<String>();
            }

		}
    }
}
