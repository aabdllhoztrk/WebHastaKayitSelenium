using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHastaKayitSelenium
{
    static class TcNoGenerator
    {
		
        public static string Generate()
        {
			var digits = new int[11];

			var randId = GenerateRandomId();
			
			for (var i = 0; i < 9; i++)
			{
				digits[i] = Convert.ToInt32(randId[i].ToString());
			}
			digits[9] = ((digits[0] + digits[2] + digits[4] + digits[6] + digits[8]) * 7 -
							(digits[1] + digits[3] + digits[5] + digits[7])) % 10;
			digits[10] = (digits[0] + digits[1] + digits[2] + digits[3] + digits[4] + digits[5] +
						digits[6] + digits[7] + digits[8] + digits[9]) % 10;

			string result = "";
            foreach (var item in digits)
            {
				result += item;
            }
			return result;
					
			
		}
		public static string GenerateRandomId()
		{
			const int MIN = 100000000;
			const int MAX = 999999999;
			var r = new Random();
			var result=r.Next(MIN,MAX);
				
			return result.ToString();
			
		}
    }
}
