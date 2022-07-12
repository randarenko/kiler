using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace kiler
{
	public partial class Form1 : Form
	{
		List<string> oniZheDetiNahuj = new List<string>();
		List<string> ktoJa = new List<string>();
		int bekapDedu = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string[] kto = File.ReadAllLines(@"C:\kiler\data2.txt");
			string[] kavo = File.ReadAllLines(@"C:\kiler\backups\ktoja.txt");
			polozhi.View = View.List;
			if (kavo.Length == 0)
			{
				kavo = new string[kto.Length+1];
				for (int i = 0; i < kto.Length+1; i++)
				{
					kavo[i] = "0";
				}
			}
			bekapDedu = int.Parse(kavo[0]);
			for (int i = 0; i<kto.Length;i++)
			{
				oniZheDetiNahuj.Add(kto[i]);
				ktoJa.Add(kavo[i + 1]);
				polozhi.Items.Add(kto[i]);
				polozhi.Items[i].BackColor = Color.Green;
			}
			List<string> kuda = new List<string>(oniZheDetiNahuj.OrderBy(x => x));
			foreach (var d in kuda)
			{
				bydloBliat.Items.Add(d);
				suka.Items.Add(d);
			}
			DavajPoNovoj();
		}

		private void bydloBliat_TextChanged(object sender, EventArgs e)
		{
			

		}

		private void udar_Click(object sender, EventArgs e)
		{
			string kavoUdar = bydloBliat.SelectedItem as string;
			int nomer = oniZheDetiNahuj.IndexOf(kavoUdar);
			ktoJa[nomer] = "1";
			DavajPoNovoj();
		}
		private void DavajPoNovoj()
		{
			for (int i = 0; i < polozhi.Items.Count; i++)
			{
				if (ktoJa[i] == "1")
				{
					polozhi.Items[i].BackColor = Color.Red;
				}
				else
				{
					polozhi.Items[i].BackColor = Color.Green;
				}	
			}
			string blia = "ktoja" + bekapDedu.ToString() + ".txt";
			List<string> mimo = new List<string>();
			mimo.Add((bekapDedu + 1).ToString());
			foreach (var item in ktoJa)
			{
				mimo.Add(item);
			}
			string[] naVyhod = mimo.ToArray();
			File.WriteAllLines(@"C:\kiler\backups\ktoja.txt", naVyhod);
			File.WriteAllLines(@"C:\kiler\backups\" + blia, naVyhod);
		}

		private void miska_Click(object sender, EventArgs e)
		{
			string kavoUdar = bydloBliat.SelectedItem as string;
			int nomer = oniZheDetiNahuj.IndexOf(kavoUdar);
			ktoJa[nomer] = "0";
			DavajPoNovoj();
		}

		private void sterzhen_Click(object sender, EventArgs e)
		{
			string kavoUdar = polozhi.SelectedItems[0].Text;
			int nomer = oniZheDetiNahuj.IndexOf(kavoUdar);
			ktoJa[nomer] = "1";
			DavajPoNovoj();
		}

		private void dosviazi_click(object sender, EventArgs e)
		{
			string kavoUdar = polozhi.SelectedItems[0].Text;
			int nomer = oniZheDetiNahuj.IndexOf(kavoUdar);
			ktoJa[nomer] = "0";
			DavajPoNovoj();
		}
	}
}
