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
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string[] kto = File.ReadAllLines(@"C:\kiler\data2.txt");
			polozhi.View = View.List;
			for (int i = 0; i<kto.Length;i++)
			{
				oniZheDetiNahuj.Add(kto[i]);
				polozhi.Items.Add(kto[i]);
				polozhi.Items[i].BackColor = Color.Green;
			}
			List<string> kuda = new List<string>(oniZheDetiNahuj.OrderBy(x => x));
			foreach (var d in kuda)
			{
				bydloBliat.Items.Add(d);
			}
		}

		private void bydloBliat_TextChanged(object sender, EventArgs e)
		{
			

		}
	}
}
