using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigDivision
{
	public partial class FormMain : System.Windows.Forms.Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			BigInt divident = new BigInt(textBoxDivident.Text);
			BigInt divider = new BigInt(textBoxDivider.Text);
			textBoxDivident.Text = divident.ToString();
			textBoxDivider.Text = divider.ToString();

			textBoxQuotient.Text = (divident / divider).ToString();
			textBoxRest.Text = (divident % divider).ToString();

			textBoxTime.Clear();
			textBoxFastTime.Clear();
			double sr = 0;
			double fastSr = 0;
			for (int i=0; i<1000; i++)
			{
				long time = 0;
				long fastTime = BigInt.divisionTest(divident, divider, ref time);
				//textBoxTime.AppendText((double)time/10000 + "\r\n");
				//textBoxFastTime.AppendText((double)fastTime/10000 + "\r\n");
				sr += (double)time/10000;
				fastSr += (double)fastTime / 10000;
			}
			sr /= 1000;
			fastSr /= 1000;
			textBoxTime.AppendText("Среднее: " + sr.ToString("0.#####"));
			textBoxFastTime.AppendText("Среднее: " + fastSr.ToString("0.#####"));

		}

		private void textBoxDivident_TextChanged(object sender, EventArgs e)
		{
			MNCalculator();
		}

		private void textBoxDivider_TextChanged(object sender, EventArgs e)
		{
			MNCalculator();
		}

		void MNCalculator()
		{
			textBoxMN.Text = "m= " + textBoxDivident.TextLength + "\tn= " + textBoxDivider.TextLength;
		}

	}
}
