using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilutionSolution
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void NewSolutionButtonClick(object sender, EventArgs e)
		{
			if (!newSolutionPanel.Visible)
				newSolutionPanel.Visible = true;
			else newSolutionPanel.Visible = false;

		}

		private void NewDilutionButtonClick(object sender, EventArgs e)
		{
			if (!existingSolutionPanel.Visible)
				existingSolutionPanel.Visible = true;
			else existingSolutionPanel.Visible = false;
		}

		private void NewSerialDilutionButtonClick(object sender, EventArgs e)
		{
			if (!serialDilutionPanel.Visible)
				serialDilutionPanel.Visible = true;
			else serialDilutionPanel.Visible = false;
		}

		private void EquationButtonClick(object sender, EventArgs e)
		{
			if (!equationPanelArea.Visible && !equationPanelBorder.Visible)
			{
				equationPanelArea.Visible = true;
				equationPanelBorder.Visible = true;
			}
			else
			{
				equationPanelArea.Visible = false;
				equationPanelBorder.Visible = false;
			}
			
		}

		private void EquationPanelArea_Paint(object sender, PaintEventArgs e)
		{

		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			newSolutionPanel.Visible = false;
		}

		private void BackButton3_Click(object sender, EventArgs e)
		{
			serialDilutionPanel.Visible = false;
		}

		private void BackButton2_Click(object sender, EventArgs e)
		{
			existingSolutionPanel.Visible = false;
		}
	}
}
