/*
 * Created by SharpDevelop.
 * User: yo
 * Date: 14/4/2021
 * Time: 00:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace software_install
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelTop;

		private System.Windows.Forms.Button botonCerrar;
		private System.Windows.Forms.Button botonResta;
		private System.Windows.Forms.Panel panelTopMenu;
		private System.Windows.Forms.Button botonOpcInstall;
		private System.Windows.Forms.Label NameSoftw;
		private System.Windows.Forms.Button botonOpcList;
		private System.Windows.Forms.Panel panelCont;
		private System.Windows.Forms.Panel panelContInstal;
		private System.Windows.Forms.Label textExecut;
		private System.Windows.Forms.Button botonOpFile;
		private System.Windows.Forms.TextBox boxUbi;
		private System.Windows.Forms.Label textUbiFile;
		private System.Windows.Forms.FlowLayoutPanel panelOpcExec;
		private System.Windows.Forms.RadioButton radBotonAdmin;
		private System.Windows.Forms.RadioButton radBotonNormal;
		private System.Windows.Forms.FlowLayoutPanel panelPriori;
		private System.Windows.Forms.RadioButton radBotonPriAlta;
		private System.Windows.Forms.RadioButton radBotonPriMedia;
		private System.Windows.Forms.RadioButton radBotonPriBaja;
		private System.Windows.Forms.Label TextPrio;
		private System.Windows.Forms.FlowLayoutPanel panelDoEnd;
		private System.Windows.Forms.RadioButton radBotonTurnOff;
		private System.Windows.Forms.RadioButton radBotonHiber;
		private System.Windows.Forms.RadioButton radBotonLayOff;
		private System.Windows.Forms.Label TextDoEnd;
		private System.Windows.Forms.Panel panelConfir;
		private System.Windows.Forms.Button botonCancel;
		private System.Windows.Forms.Button botonInstall;
		private System.Windows.Forms.PictureBox imgLogo;
		private System.Windows.Forms.Panel panelContList;
		private System.Windows.Forms.Label TextManteList;

		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>

		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelTop = new System.Windows.Forms.Panel();
			this.imgLogo = new System.Windows.Forms.PictureBox();
			this.botonCerrar = new System.Windows.Forms.Button();
			this.botonResta = new System.Windows.Forms.Button();
			this.NameSoftw = new System.Windows.Forms.Label();
			this.panelTopMenu = new System.Windows.Forms.Panel();
			this.botonOpcInstall = new System.Windows.Forms.Button();
			this.botonOpcList = new System.Windows.Forms.Button();
			this.panelCont = new System.Windows.Forms.Panel();
			this.panelContInstal = new System.Windows.Forms.Panel();
			this.panelContList = new System.Windows.Forms.Panel();
			this.TextManteList = new System.Windows.Forms.Label();
			this.panelConfir = new System.Windows.Forms.Panel();
			this.botonCancel = new System.Windows.Forms.Button();
			this.botonInstall = new System.Windows.Forms.Button();
			this.panelDoEnd = new System.Windows.Forms.FlowLayoutPanel();
			this.radBotonTurnOff = new System.Windows.Forms.RadioButton();
			this.radBotonHiber = new System.Windows.Forms.RadioButton();
			this.radBotonLayOff = new System.Windows.Forms.RadioButton();
			this.TextDoEnd = new System.Windows.Forms.Label();
			this.panelPriori = new System.Windows.Forms.FlowLayoutPanel();
			this.radBotonPriAlta = new System.Windows.Forms.RadioButton();
			this.radBotonPriMedia = new System.Windows.Forms.RadioButton();
			this.radBotonPriBaja = new System.Windows.Forms.RadioButton();
			this.TextPrio = new System.Windows.Forms.Label();
			this.panelOpcExec = new System.Windows.Forms.FlowLayoutPanel();
			this.radBotonAdmin = new System.Windows.Forms.RadioButton();
			this.radBotonNormal = new System.Windows.Forms.RadioButton();
			this.textExecut = new System.Windows.Forms.Label();
			this.botonOpFile = new System.Windows.Forms.Button();
			this.boxUbi = new System.Windows.Forms.TextBox();
			this.textUbiFile = new System.Windows.Forms.Label();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
			this.panelTopMenu.SuspendLayout();
			this.panelCont.SuspendLayout();
			this.panelContInstal.SuspendLayout();
			this.panelContList.SuspendLayout();
			this.panelConfir.SuspendLayout();
			this.panelDoEnd.SuspendLayout();
			this.panelPriori.SuspendLayout();
			this.panelOpcExec.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
			this.panelTop.Controls.Add(this.imgLogo);
			this.panelTop.Controls.Add(this.botonCerrar);
			this.panelTop.Controls.Add(this.botonResta);
			this.panelTop.Controls.Add(this.NameSoftw);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(484, 29);
			this.panelTop.TabIndex = 2;
			// 
			// imgLogo
			// 
			this.imgLogo.BackColor = System.Drawing.Color.Transparent;
			this.imgLogo.ErrorImage = null;
			this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
			this.imgLogo.InitialImage = null;
			this.imgLogo.Location = new System.Drawing.Point(16, 0);
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.Size = new System.Drawing.Size(26, 27);
			this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgLogo.TabIndex = 18;
			this.imgLogo.TabStop = false;
			// 
			// botonCerrar
			// 
			this.botonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.botonCerrar.FlatAppearance.BorderSize = 0;
			this.botonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.botonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.botonCerrar.ForeColor = System.Drawing.Color.White;
			this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
			this.botonCerrar.Location = new System.Drawing.Point(436, 3);
			this.botonCerrar.Name = "botonCerrar";
			this.botonCerrar.Size = new System.Drawing.Size(35, 22);
			this.botonCerrar.TabIndex = 6;
			this.botonCerrar.UseVisualStyleBackColor = true;
			this.botonCerrar.Click += new System.EventHandler(this.BotonCerrarClick);
			// 
			// botonResta
			// 
			this.botonResta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.botonResta.FlatAppearance.BorderSize = 0;
			this.botonResta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonResta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.botonResta.ForeColor = System.Drawing.Color.White;
			this.botonResta.Image = ((System.Drawing.Image)(resources.GetObject("botonResta.Image")));
			this.botonResta.Location = new System.Drawing.Point(398, 3);
			this.botonResta.Name = "botonResta";
			this.botonResta.Size = new System.Drawing.Size(35, 22);
			this.botonResta.TabIndex = 5;
			this.botonResta.UseVisualStyleBackColor = true;
			this.botonResta.Click += new System.EventHandler(this.BotonRestaClick);
			// 
			// NameSoftw
			// 
			this.NameSoftw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.NameSoftw.ForeColor = System.Drawing.Color.White;
			this.NameSoftw.Location = new System.Drawing.Point(48, 5);
			this.NameSoftw.Name = "NameSoftw";
			this.NameSoftw.Size = new System.Drawing.Size(119, 21);
			this.NameSoftw.TabIndex = 4;
			this.NameSoftw.Text = "Software Installer";
			// 
			// panelTopMenu
			// 
			this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
			this.panelTopMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelTopMenu.Controls.Add(this.botonOpcInstall);
			this.panelTopMenu.Controls.Add(this.botonOpcList);
			this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTopMenu.Location = new System.Drawing.Point(0, 29);
			this.panelTopMenu.Name = "panelTopMenu";
			this.panelTopMenu.Size = new System.Drawing.Size(484, 35);
			this.panelTopMenu.TabIndex = 3;
			// 
			// botonOpcInstall
			// 
			this.botonOpcInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonOpcInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonOpcInstall.FlatAppearance.BorderSize = 0;
			this.botonOpcInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonOpcInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonOpcInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonOpcInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.botonOpcInstall.ForeColor = System.Drawing.Color.White;
			this.botonOpcInstall.Image = ((System.Drawing.Image)(resources.GetObject("botonOpcInstall.Image")));
			this.botonOpcInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.botonOpcInstall.Location = new System.Drawing.Point(12, 0);
			this.botonOpcInstall.Name = "botonOpcInstall";
			this.botonOpcInstall.Size = new System.Drawing.Size(105, 35);
			this.botonOpcInstall.TabIndex = 4;
			this.botonOpcInstall.Text = "      Installation";
			this.botonOpcInstall.UseVisualStyleBackColor = false;
			this.botonOpcInstall.Click += new System.EventHandler(this.BotonOpcInstallClick);
			// 
			// botonOpcList
			// 
			this.botonOpcList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.botonOpcList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonOpcList.FlatAppearance.BorderSize = 0;
			this.botonOpcList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonOpcList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonOpcList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonOpcList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.botonOpcList.ForeColor = System.Drawing.Color.White;
			this.botonOpcList.Image = ((System.Drawing.Image)(resources.GetObject("botonOpcList.Image")));
			this.botonOpcList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.botonOpcList.Location = new System.Drawing.Point(114, 0);
			this.botonOpcList.Name = "botonOpcList";
			this.botonOpcList.Size = new System.Drawing.Size(75, 35);
			this.botonOpcList.TabIndex = 5;
			this.botonOpcList.Text = "      List";
			this.botonOpcList.UseVisualStyleBackColor = false;
			this.botonOpcList.Click += new System.EventHandler(this.BotonOpcListClick);
			// 
			// panelCont
			// 
			this.panelCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(30)))));
			this.panelCont.Controls.Add(this.panelContInstal);
			this.panelCont.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCont.Location = new System.Drawing.Point(0, 64);
			this.panelCont.Name = "panelCont";
			this.panelCont.Size = new System.Drawing.Size(484, 457);
			this.panelCont.TabIndex = 4;
			// 
			// panelContInstal
			// 
			this.panelContInstal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.panelContInstal.Controls.Add(this.panelContList);
			this.panelContInstal.Controls.Add(this.panelConfir);
			this.panelContInstal.Controls.Add(this.panelDoEnd);
			this.panelContInstal.Controls.Add(this.TextDoEnd);
			this.panelContInstal.Controls.Add(this.panelPriori);
			this.panelContInstal.Controls.Add(this.TextPrio);
			this.panelContInstal.Controls.Add(this.panelOpcExec);
			this.panelContInstal.Controls.Add(this.textExecut);
			this.panelContInstal.Controls.Add(this.botonOpFile);
			this.panelContInstal.Controls.Add(this.boxUbi);
			this.panelContInstal.Controls.Add(this.textUbiFile);
			this.panelContInstal.Location = new System.Drawing.Point(12, 0);
			this.panelContInstal.Name = "panelContInstal";
			this.panelContInstal.Size = new System.Drawing.Size(459, 445);
			this.panelContInstal.TabIndex = 0;
			// 
			// panelContList
			// 
			this.panelContList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.panelContList.Controls.Add(this.TextManteList);
			this.panelContList.Location = new System.Drawing.Point(0, 0);
			this.panelContList.Name = "panelContList";
			this.panelContList.Size = new System.Drawing.Size(459, 445);
			this.panelContList.TabIndex = 2;
			this.panelContList.Visible = false;
			// 
			// TextManteList
			// 
			this.TextManteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.TextManteList.ForeColor = System.Drawing.Color.White;
			this.TextManteList.Location = new System.Drawing.Point(127, 183);
			this.TextManteList.Name = "TextManteList";
			this.TextManteList.Size = new System.Drawing.Size(229, 33);
			this.TextManteList.TabIndex = 0;
			this.TextManteList.Text = "List maintenance";
			// 
			// panelConfir
			// 
			this.panelConfir.Controls.Add(this.botonCancel);
			this.panelConfir.Controls.Add(this.botonInstall);
			this.panelConfir.Location = new System.Drawing.Point(295, 391);
			this.panelConfir.Name = "panelConfir";
			this.panelConfir.Size = new System.Drawing.Size(142, 29);
			this.panelConfir.TabIndex = 17;
			// 
			// botonCancel
			// 
			this.botonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.botonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
			this.botonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
			this.botonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.botonCancel.ForeColor = System.Drawing.Color.White;
			this.botonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.botonCancel.Location = new System.Drawing.Point(78, 3);
			this.botonCancel.Name = "botonCancel";
			this.botonCancel.Size = new System.Drawing.Size(61, 23);
			this.botonCancel.TabIndex = 12;
			this.botonCancel.Text = "Cancel";
			this.botonCancel.UseVisualStyleBackColor = false;
			this.botonCancel.Click += new System.EventHandler(this.BotonCancelClick);
			// 
			// botonInstall
			// 
			this.botonInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonInstall.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.botonInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
			this.botonInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
			this.botonInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.botonInstall.ForeColor = System.Drawing.Color.White;
			this.botonInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.botonInstall.Location = new System.Drawing.Point(0, 3);
			this.botonInstall.Name = "botonInstall";
			this.botonInstall.Size = new System.Drawing.Size(61, 23);
			this.botonInstall.TabIndex = 11;
			this.botonInstall.Text = "Install";
			this.botonInstall.UseVisualStyleBackColor = false;
			this.botonInstall.Click += new System.EventHandler(this.BotonInstallClick);
			// 
			// panelDoEnd
			// 
			this.panelDoEnd.Controls.Add(this.radBotonTurnOff);
			this.panelDoEnd.Controls.Add(this.radBotonHiber);
			this.panelDoEnd.Controls.Add(this.radBotonLayOff);
			this.panelDoEnd.Location = new System.Drawing.Point(127, 259);
			this.panelDoEnd.Name = "panelDoEnd";
			this.panelDoEnd.Size = new System.Drawing.Size(114, 91);
			this.panelDoEnd.TabIndex = 16;
			// 
			// radBotonTurnOff
			// 
			this.radBotonTurnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radBotonTurnOff.ForeColor = System.Drawing.Color.White;
			this.radBotonTurnOff.Location = new System.Drawing.Point(3, 3);
			this.radBotonTurnOff.Name = "radBotonTurnOff";
			this.radBotonTurnOff.Size = new System.Drawing.Size(104, 24);
			this.radBotonTurnOff.TabIndex = 1;
			this.radBotonTurnOff.TabStop = true;
			this.radBotonTurnOff.Text = "Turn off";
			this.radBotonTurnOff.UseVisualStyleBackColor = true;
			// 
			// radBotonHiber
			// 
			this.radBotonHiber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radBotonHiber.ForeColor = System.Drawing.Color.White;
			this.radBotonHiber.Location = new System.Drawing.Point(3, 33);
			this.radBotonHiber.Name = "radBotonHiber";
			this.radBotonHiber.Size = new System.Drawing.Size(104, 24);
			this.radBotonHiber.TabIndex = 0;
			this.radBotonHiber.TabStop = true;
			this.radBotonHiber.Text = "Hibernate";
			this.radBotonHiber.UseVisualStyleBackColor = true;
			// 
			// radBotonLayOff
			// 
			this.radBotonLayOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radBotonLayOff.ForeColor = System.Drawing.Color.White;
			this.radBotonLayOff.Location = new System.Drawing.Point(3, 63);
			this.radBotonLayOff.Name = "radBotonLayOff";
			this.radBotonLayOff.Size = new System.Drawing.Size(104, 24);
			this.radBotonLayOff.TabIndex = 2;
			this.radBotonLayOff.TabStop = true;
			this.radBotonLayOff.Text = "Lay off";
			this.radBotonLayOff.UseVisualStyleBackColor = true;
			// 
			// TextDoEnd
			// 
			this.TextDoEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.TextDoEnd.ForeColor = System.Drawing.Color.White;
			this.TextDoEnd.Location = new System.Drawing.Point(23, 259);
			this.TextDoEnd.Name = "TextDoEnd";
			this.TextDoEnd.Size = new System.Drawing.Size(105, 23);
			this.TextDoEnd.TabIndex = 15;
			this.TextDoEnd.Text = "Do at the end";
			// 
			// panelPriori
			// 
			this.panelPriori.Controls.Add(this.radBotonPriAlta);
			this.panelPriori.Controls.Add(this.radBotonPriMedia);
			this.panelPriori.Controls.Add(this.radBotonPriBaja);
			this.panelPriori.Location = new System.Drawing.Point(127, 150);
			this.panelPriori.Name = "panelPriori";
			this.panelPriori.Size = new System.Drawing.Size(114, 91);
			this.panelPriori.TabIndex = 14;
			// 
			// radBotonPriAlta
			// 
			this.radBotonPriAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radBotonPriAlta.ForeColor = System.Drawing.Color.White;
			this.radBotonPriAlta.Location = new System.Drawing.Point(3, 3);
			this.radBotonPriAlta.Name = "radBotonPriAlta";
			this.radBotonPriAlta.Size = new System.Drawing.Size(104, 24);
			this.radBotonPriAlta.TabIndex = 1;
			this.radBotonPriAlta.TabStop = true;
			this.radBotonPriAlta.Text = "High";
			this.radBotonPriAlta.UseVisualStyleBackColor = true;
			// 
			// radBotonPriMedia
			// 
			this.radBotonPriMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radBotonPriMedia.ForeColor = System.Drawing.Color.White;
			this.radBotonPriMedia.Location = new System.Drawing.Point(3, 33);
			this.radBotonPriMedia.Name = "radBotonPriMedia";
			this.radBotonPriMedia.Size = new System.Drawing.Size(104, 24);
			this.radBotonPriMedia.TabIndex = 0;
			this.radBotonPriMedia.TabStop = true;
			this.radBotonPriMedia.Text = "Half";
			this.radBotonPriMedia.UseVisualStyleBackColor = true;
			// 
			// radBotonPriBaja
			// 
			this.radBotonPriBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radBotonPriBaja.ForeColor = System.Drawing.Color.White;
			this.radBotonPriBaja.Location = new System.Drawing.Point(3, 63);
			this.radBotonPriBaja.Name = "radBotonPriBaja";
			this.radBotonPriBaja.Size = new System.Drawing.Size(104, 24);
			this.radBotonPriBaja.TabIndex = 2;
			this.radBotonPriBaja.TabStop = true;
			this.radBotonPriBaja.Text = "Short";
			this.radBotonPriBaja.UseVisualStyleBackColor = true;
			// 
			// TextPrio
			// 
			this.TextPrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.TextPrio.ForeColor = System.Drawing.Color.White;
			this.TextPrio.Location = new System.Drawing.Point(23, 150);
			this.TextPrio.Name = "TextPrio";
			this.TextPrio.Size = new System.Drawing.Size(105, 23);
			this.TextPrio.TabIndex = 13;
			this.TextPrio.Text = "Priority type";
			// 
			// panelOpcExec
			// 
			this.panelOpcExec.Controls.Add(this.radBotonAdmin);
			this.panelOpcExec.Controls.Add(this.radBotonNormal);
			this.panelOpcExec.Location = new System.Drawing.Point(127, 75);
			this.panelOpcExec.Name = "panelOpcExec";
			this.panelOpcExec.Size = new System.Drawing.Size(114, 59);
			this.panelOpcExec.TabIndex = 12;
			// 
			// radBotonAdmin
			// 
			this.radBotonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radBotonAdmin.ForeColor = System.Drawing.Color.White;
			this.radBotonAdmin.Location = new System.Drawing.Point(3, 3);
			this.radBotonAdmin.Name = "radBotonAdmin";
			this.radBotonAdmin.Size = new System.Drawing.Size(104, 24);
			this.radBotonAdmin.TabIndex = 0;
			this.radBotonAdmin.TabStop = true;
			this.radBotonAdmin.Text = "Administrator";
			this.radBotonAdmin.UseVisualStyleBackColor = true;
			// 
			// radBotonNormal
			// 
			this.radBotonNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radBotonNormal.ForeColor = System.Drawing.Color.White;
			this.radBotonNormal.Location = new System.Drawing.Point(3, 33);
			this.radBotonNormal.Name = "radBotonNormal";
			this.radBotonNormal.Size = new System.Drawing.Size(104, 24);
			this.radBotonNormal.TabIndex = 1;
			this.radBotonNormal.TabStop = true;
			this.radBotonNormal.Text = "Normal";
			this.radBotonNormal.UseVisualStyleBackColor = true;
			// 
			// textExecut
			// 
			this.textExecut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.textExecut.ForeColor = System.Drawing.Color.White;
			this.textExecut.Location = new System.Drawing.Point(23, 75);
			this.textExecut.Name = "textExecut";
			this.textExecut.Size = new System.Drawing.Size(105, 23);
			this.textExecut.TabIndex = 11;
			this.textExecut.Text = "Execution type";
			// 
			// botonOpFile
			// 
			this.botonOpFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
			this.botonOpFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.botonOpFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
			this.botonOpFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
			this.botonOpFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonOpFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.botonOpFile.ForeColor = System.Drawing.Color.White;
			this.botonOpFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.botonOpFile.Location = new System.Drawing.Point(382, 30);
			this.botonOpFile.Name = "botonOpFile";
			this.botonOpFile.Size = new System.Drawing.Size(39, 23);
			this.botonOpFile.TabIndex = 10;
			this.botonOpFile.Text = "File";
			this.botonOpFile.UseVisualStyleBackColor = false;
			this.botonOpFile.Click += new System.EventHandler(this.BotonOpenFileClick);
			// 
			// boxUbi
			// 
			this.boxUbi.Location = new System.Drawing.Point(127, 34);
			this.boxUbi.Name = "boxUbi";
			this.boxUbi.Size = new System.Drawing.Size(250, 20);
			this.boxUbi.TabIndex = 9;
			// 
			// textUbiFile
			// 
			this.textUbiFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.textUbiFile.ForeColor = System.Drawing.Color.White;
			this.textUbiFile.Location = new System.Drawing.Point(23, 34);
			this.textUbiFile.Name = "textUbiFile";
			this.textUbiFile.Size = new System.Drawing.Size(98, 23);
			this.textUbiFile.TabIndex = 8;
			this.textUbiFile.Text = "File location";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(484, 521);
			this.Controls.Add(this.panelCont);
			this.Controls.Add(this.panelTopMenu);
			this.Controls.Add(this.panelTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Software Installer";
			this.panelTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
			this.panelTopMenu.ResumeLayout(false);
			this.panelCont.ResumeLayout(false);
			this.panelContInstal.ResumeLayout(false);
			this.panelContInstal.PerformLayout();
			this.panelContList.ResumeLayout(false);
			this.panelConfir.ResumeLayout(false);
			this.panelDoEnd.ResumeLayout(false);
			this.panelPriori.ResumeLayout(false);
			this.panelOpcExec.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
