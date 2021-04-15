/*
 * Created by SharpDevelop.
 * User: yo
 * Date: 14/4/2021
 * Time: 00:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace software_install
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void BotonCerrarClick(object sender, EventArgs e)
		{
			DialogResult Result = MessageBox.Show("Are you sure you want to close the software?" +
												"If you close it, nothing will be installed",
												"Close software",MessageBoxButtons.OKCancel);
			if (Result == DialogResult.OK ) 
			{
				Application.Exit();
			}
		}
		
		private void BotonRestaClick(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		
		
		private void BotonOpenFileClick(object sender, EventArgs e)
		{
			OpenFileDialog buscar = new OpenFileDialog();
			if(buscar.ShowDialog() == DialogResult.OK)
			{
				boxUbi.Text = buscar.FileName;
			}
		}

		void BotonOpcInstallClick(object sender, EventArgs e)
		{
			botonOpcInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			botonOpcList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			panelContList.Visible = false;
			panelContInstal.Visible = true;
			
		}
		void BotonOpcListClick(object sender, EventArgs e)
		{
			botonOpcInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			botonOpcList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			panelContList.Visible = true;
			panelContInstal.Visible = true;
		}

		private RadioButton verifExec()
		{
			if(radBotonAdmin.Checked == true)
			{
				return radBotonAdmin;
			}
			else if(radBotonNormal.Checked == true)
			{
				return radBotonNormal;
			}
			else
			{
				return radBotonAdmin;
			}
		}

		private RadioButton verifiPriori()
		{
			if(radBotonPriAlta.Checked == true)
			{
				return radBotonPriAlta;
			}
			else if(radBotonPriMedia.Checked == true)
			{
				return radBotonPriMedia;
			}
			else if(radBotonPriBaja.Checked == true)
			{
				return radBotonPriBaja;
			}
			else
			{
				return radBotonPriAlta;
			}
		}
		
		private RadioButton verifiDoEnd()
		{
			if(radBotonTurnOff.Checked == true)
			{
				return radBotonTurnOff;
			}
			else if(radBotonLayOff.Checked == true)
			{
				return radBotonLayOff;
			}
			else if(radBotonHiber.Checked == true)
			{
				return radBotonHiber;
			}
			else
			{
				return radBotonTurnOff;
			}
		}
		private void BotonCancelClick(object sender, EventArgs e)
		{
				boxUbi.Text = null;

				radBotonAdmin.Checked = false;
				radBotonNormal.Checked = false;

				radBotonPriAlta.Checked = false;
				radBotonPriMedia.Checked = false;
				radBotonPriBaja.Checked = false;

				radBotonTurnOff.Checked = false;
				radBotonLayOff.Checked = false;
				radBotonHiber.Checked = false;
		}
		void BotonInstallClick(object sender, EventArgs e)
		{
			if(verifExec().Checked == true && verifiPriori().Checked ==  true && verifiDoEnd().Checked == true && File.Exists(boxUbi.Text))
			{
				Process.Start(boxUbi.Text);
				MessageBox.Show("exec: "+verifExec().Checked+"\npriori: "+
				verifiPriori().Checked+"\ndo end: "+
				verifiDoEnd().Checked+
				"\nFile: "+boxUbi.Text);
			}
			else
			{
				MessageBox.Show("Select an option or enter the location of the file you want to install",
								"Alert");
			}
		}


	}
}
