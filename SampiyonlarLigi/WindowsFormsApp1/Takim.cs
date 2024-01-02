using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	internal class Takim
	{
		private string takımIsmi; 
		private string takımUlke;
		public Takim(string isim,string ukle)//Takım metoduyla takımısmi ve takımülkeye ulaşılmış olur
		{
			takımIsmi = isim;
			takımUlke = ukle;
		}
		public string TeamName
		{
			get
			{
				return takımIsmi;//veri okunduğu zaman, döndür
			}
			set
			{
				takımIsmi =value;//formlarla oluşturduğumuz değeri takım isme ver
			}
		}
		public string TeamCountry
		{
			get
			{
				return takımUlke;
			}
			set
			{
				takımUlke=value;//formlarla oluşturduğumuz değeri takım ulkeye ver
			}
		}
		public override string ToString()
		{
			return takımIsmi + "-" + takımUlke;// takım ismini ve arasına tire olacak şekilde ulke ismini döndürür
		}

	}
}
