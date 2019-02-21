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
		private List<String> errorMessages;

		public List<String> ErrorMessages 
		{
			get 
			{
				errorMessages;
			}
		}
       
		public ImportResult(){
			TotalRows = 0;
			ImportedRows = 0;
			FailedRows = 0;
			errorMessages.Clear;

		
		}

      

       
    }
}
