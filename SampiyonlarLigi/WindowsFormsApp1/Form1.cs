using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
	public partial class A : Form
	{
		//verileri veya nesneleri listelememizi sağlar
		List<Takim> takimlar;         // Takım adlı sınıfı cağırdık
		List<ListBox>torbalar=new List<ListBox>(); //listboxlar üzerinde
		List<ListBox> guruplar = new List<ListBox>();

		int a=0;
		


		public A()
		{
			InitializeComponent();
		}

		private void A_Load(object sender, EventArgs e)
		{
			Takim yenitakim = null; // ilk gelecek yeni takımı bilmediğimizden null olarak atanır

			takimlar = new List<Takim>();//oluşturduğumuz takımları tutar

			yenitakim = new Takim("Bayer Münih","Almanya");//parantez icinde 2 değer bulunur bit takım ismi diğeri takım ülkesi
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Fenerbahce", "Türkiye");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("FC Barcelona", "İspanya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Chelsea", "İngiltere");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Real Madrid", "İspanya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Manchhester United", "İspanya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Arsenal", "İngiltere");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Porto", "Portekiz");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Benfiga", "Portekiz");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Atletico Madrid", "İspanya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Shaktar ", "Ukranya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Milan", "İtalya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Schalke 04", "Almanya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Marsiyo", "Fransa");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("CSKA Moskovo", "Rusya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("PSG", "Fransa");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Juventus", "İtalya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Zenit", "Rusya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Machester City","İngiltere");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Ajax", "Holanda");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Basel", "İsvicre");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Dortmund", "Almanya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Galatasaray", "Türkiye");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Beşiktaş", "Türkiye");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Napoli", "İtalya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("celtic", "İskocya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("TrabzonSpor", "Türkiye");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Roma", "İtalya");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Real Sociedad", "Türkiye");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Austria Wien", "Türkiye");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Victoria", "Türkiye");
			takimlar.Add(yenitakim);
			yenitakim = new Takim("Menemen spor", "Türkiye");
			takimlar.Add(yenitakim);

			this.BackColor = Color.Orange;
		}
	    
		private void button1_Click_1(object sender, EventArgs e)
		{
			//torba buttonu
			if(a==0)
			{

				Random rasgele = new Random();//random rasgele metodu oluşturur
				List<int> secilentakimlar = new List<int>();
				for (int i = 0; i < takimlar.Count; i++)//takım sayısı kadar dön
				{
					int secilentakim = rasgele.Next(0, takimlar.Count); //takımları rastgele sec
					if (secilentakimlar.Contains(secilentakim))//secilen takım secilen takımların arasındaysa 
					{
						i--;
					}
					else
					{
						secilentakimlar.Add(secilentakim);//secilen takımlara secilen takımı ekle
					}
				}
				for (int i = 0; i < secilentakimlar.Count; i++)//secilen takımlar sayısı kadar dön
				{
					//her torbaya 8 takım atacak şekilde atar
					if (i < 8)
					{
						LstTorba1.Items.Add(takimlar[secilentakimlar[i]]);
					}
					else if (i < 16)
					{
						LstTorba2.Items.Add(takimlar[secilentakimlar[i]]);
					}
					else if (i < 24)
					{
						LstTorba3.Items.Add(takimlar[secilentakimlar[i]]);
					}
					else
					{
						LstTorba4.Items.Add(takimlar[secilentakimlar[i]]);
					}
				}
				//4 torbaya ilgili takımları yazdırrır
				torbalar.Add(LstTorba1);
				torbalar.Add(LstTorba2);
				torbalar.Add(LstTorba3);
				torbalar.Add(LstTorba4);

				//gurplara takımı atar
				guruplar.Add(listBox1);
				guruplar.Add(listBox2);
				guruplar.Add(listBox3);
				guruplar.Add(listBox4);
				guruplar.Add(listBox5);
				guruplar.Add(listBox6);
				guruplar.Add(listBox7);
				guruplar.Add(listBox8);


				a++;
			}
			//Torba buttonu

			
		
			/*Random rasgele = new Random();//random rasgele metodu oluşturur
			List<int> secilentakimlar = new List<int>();
			for (int i = 0; i < takimlar.Count; i++)//takım sayısı kadar dön
			{
				int secilentakim = rasgele.Next(0, takimlar.Count); //takımları rastgele sec
				if (secilentakimlar.Contains(secilentakim))//secilen takım secilen takımların arasındaysa 
				{
					i--;
				}
				else
				{
					secilentakimlar.Add(secilentakim);//secilen takımlara secilen takımı ekle
				}
			}
			for (int i = 0; i < secilentakimlar.Count; i++)//secilen takımlar sayısı kadar dön
			{
				//her torbaya 8 takım atacak şekilde atar
				if (i < 8)
				{
					LstTorba1.Items.Add(takimlar[secilentakimlar[i]]);
				}
				else if (i < 16)
				{
					LstTorba2.Items.Add(takimlar[secilentakimlar[i]]);
				}
				else if (i < 24)
				{
					LstTorba3.Items.Add(takimlar[secilentakimlar[i]]);
				}
				else
				{
					LstTorba4.Items.Add(takimlar[secilentakimlar[i]]);
				}
			}
			//4 torbaya ilgili takımları yazdırrır
			torbalar.Add(LstTorba1);
			torbalar.Add(LstTorba2);
			torbalar.Add(LstTorba3);
			torbalar.Add(LstTorba4);

			//gurplara takımı atar
			guruplar.Add(listBox1);
			guruplar.Add(listBox2);
			guruplar.Add(listBox3);
			guruplar.Add(listBox4);
			guruplar.Add(listBox5);
			guruplar.Add(listBox6);
			guruplar.Add(listBox7);
			guruplar.Add(listBox8);*/


		

		}
		private void button1_Click(object sender, EventArgs e)
		{
			

		}
	


		private void button2_Click(object sender, EventArgs e)
		{
			// Gurup buttonu
			
				Random rastgele = new Random();// random rasgele metodu oluşturur
				List<int> secilentakımlar = new List<int>();
				for (int j = 0; j < 4; j++)//her gurupta max 4 takım olabilir // torba secimini yapıyor
				{
					secilentakımlar.Clear();//secilen takımları secilmesini önlemek icin aynı takım secilirse silinir 
					for (int i = 0; i < 8; i++)//torbadan guruba secme işlemini yapar
					{
						int secilentakim = rastgele.Next(0, takimlar.Count / 4);//torba işlemi yapılır 
						if (secilentakımlar.Contains(secilentakim))//secilen takımsecilen takımların arasında varmı diye kontrol ediyor
						{
							i--;
						}
						else
						{
							secilentakımlar.Add(secilentakim);// secilen takım yoksa takımı atar
						}
					}
					bool aynıulkedentakımvar = false;
					for (int k = 0; k < 8; k++)// gurup secimini yapıyor
					{
					//Items=Kontrol içerisine veri eklemek için kullanılan alandır
					aynıulkedentakımvar = Aynıulkedetakımvarmı(guruplar[k], torbalar[j].Items[secilentakımlar[k]] as Takim);//Takim classından alır
						if (aynıulkedentakımvar)//aynı ulkeden takım varsa break diyerek döngüyü kır
							break;
					}
					if (!aynıulkedentakımvar)// aynı ülkeden takım yoksa sırasıyla takımları lisboxa ata
					{
						listBox1.Items.Add(torbalar[j].Items[secilentakımlar[0]] as Takim);
						listBox2.Items.Add(torbalar[j].Items[secilentakımlar[1]] as Takim);
						listBox3.Items.Add(torbalar[j].Items[secilentakımlar[2]] as Takim);
						listBox4.Items.Add(torbalar[j].Items[secilentakımlar[3]] as Takim);
						listBox5.Items.Add(torbalar[j].Items[secilentakımlar[4]] as Takim);
						listBox6.Items.Add(torbalar[j].Items[secilentakımlar[5]] as Takim);
						listBox7.Items.Add(torbalar[j].Items[secilentakımlar[6]] as Takim);
						listBox8.Items.Add(torbalar[j].Items[secilentakımlar[7]] as Takim);
					}
					else//aynı ulkeden takım varsa j yi 1 azaltarak yeniden kura cek 
					{
						j--;
					}

				}

				MessageBox.Show("MACLAR OYNAMAYA HAZIR " +
					"ŞİMDİDEN BAŞARILAR :::)))");
				
			

		

		}
		private bool Aynıulkedetakımvarmı(ListBox grup, Takim takim)
		{
			bool durum = false;
			for (int i = 0; i < grup.Items.Count; i++)//ilgili guruba eklenen toplam takım sayısı kadar döner
			{
				Takim gruptakim = grup.Items[i] as Takim;
				if (gruptakim.TeamCountry == takim.TeamCountry)
				{
					durum = true;
					break;
				}
			}

			return durum;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//Silme Buttonu

			listBox1.Items.Clear();
			listBox2.Items.Clear();
			listBox3.Items.Clear();
			listBox4.Items.Clear();
			listBox5.Items.Clear();
			listBox6.Items.Clear();
			listBox7.Items.Clear();
			listBox8.Items.Clear();

			LstTorba1.Items.Clear();
			LstTorba2.Items.Clear();
			LstTorba3.Items.Clear();
			LstTorba4.Items.Clear();
			a--;
			MessageBox.Show("TEKRARDAN SECME YAPABİLİRSİN :::)))");
			
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		
	}
}
