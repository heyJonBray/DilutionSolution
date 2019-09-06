namespace DilutionSolution
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textSubHeader = new System.Windows.Forms.TextBox();
			this.newSolutionButton = new System.Windows.Forms.Button();
			this.newDilutionButton = new System.Windows.Forms.Button();
			this.newSerialDilutionButton = new System.Windows.Forms.Button();
			this.textHeader = new System.Windows.Forms.TextBox();
			this.textDescription = new System.Windows.Forms.TextBox();
			this.newSolutionDescription = new System.Windows.Forms.TextBox();
			this.existingSolutionDescription = new System.Windows.Forms.TextBox();
			this.serialDilutionDescription = new System.Windows.Forms.TextBox();
			this.equationPanelArea = new System.Windows.Forms.Panel();
			this.serialDilutionEquationsTitle = new System.Windows.Forms.Label();
			this.totalMixingVolumeEquation = new System.Windows.Forms.Label();
			this.totalMixingVolumeLabel = new System.Windows.Forms.Label();
			this.diluentVolumeEquation = new System.Windows.Forms.Label();
			this.diluentVolumeLabel = new System.Windows.Forms.Label();
			this.moveVolumeEquation = new System.Windows.Forms.Label();
			this.moveVolumeLabel = new System.Windows.Forms.Label();
			this.dilutionFactorEquation = new System.Windows.Forms.Label();
			this.dilutionFactorLabel = new System.Windows.Forms.Label();
			this.fixedDilutionEquation = new System.Windows.Forms.Label();
			this.fixedDilutionLabel = new System.Windows.Forms.Label();
			this.equationButton = new System.Windows.Forms.Button();
			this.equationPanelBorder = new System.Windows.Forms.Panel();
			this.newSolutionPanel = new System.Windows.Forms.Panel();
			this.newSolutionTitle = new System.Windows.Forms.Label();
			this.backButton = new System.Windows.Forms.Button();
			this.existingSolutionPanel = new System.Windows.Forms.Panel();
			this.backButton2 = new System.Windows.Forms.Button();
			this.existingSolutionTitle = new System.Windows.Forms.Label();
			this.serialDilutionPanel = new System.Windows.Forms.Panel();
			this.backButton3 = new System.Windows.Forms.Button();
			this.serialDilutionTitle = new System.Windows.Forms.Label();
			this.equationPanelArea.SuspendLayout();
			this.newSolutionPanel.SuspendLayout();
			this.existingSolutionPanel.SuspendLayout();
			this.serialDilutionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// textSubHeader
			// 
			this.textSubHeader.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textSubHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textSubHeader.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textSubHeader.Location = new System.Drawing.Point(51, 185);
			this.textSubHeader.Name = "textSubHeader";
			this.textSubHeader.ReadOnly = true;
			this.textSubHeader.Size = new System.Drawing.Size(521, 24);
			this.textSubHeader.TabIndex = 0;
			this.textSubHeader.Text = "What type of solution are you trying to create?";
			// 
			// newSolutionButton
			// 
			this.newSolutionButton.BackColor = System.Drawing.SystemColors.Highlight;
			this.newSolutionButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newSolutionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.newSolutionButton.Location = new System.Drawing.Point(51, 250);
			this.newSolutionButton.Name = "newSolutionButton";
			this.newSolutionButton.Size = new System.Drawing.Size(212, 82);
			this.newSolutionButton.TabIndex = 1;
			this.newSolutionButton.Text = "New Solution Volumetric Dilution";
			this.newSolutionButton.UseVisualStyleBackColor = false;
			this.newSolutionButton.Click += new System.EventHandler(this.NewSolutionButtonClick);
			// 
			// newDilutionButton
			// 
			this.newDilutionButton.BackColor = System.Drawing.SystemColors.Highlight;
			this.newDilutionButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newDilutionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.newDilutionButton.Location = new System.Drawing.Point(51, 352);
			this.newDilutionButton.Name = "newDilutionButton";
			this.newDilutionButton.Size = new System.Drawing.Size(212, 82);
			this.newDilutionButton.TabIndex = 2;
			this.newDilutionButton.Text = "Dilute Existing Solution";
			this.newDilutionButton.UseVisualStyleBackColor = false;
			this.newDilutionButton.Click += new System.EventHandler(this.NewDilutionButtonClick);
			// 
			// newSerialDilutionButton
			// 
			this.newSerialDilutionButton.BackColor = System.Drawing.SystemColors.Highlight;
			this.newSerialDilutionButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newSerialDilutionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.newSerialDilutionButton.Location = new System.Drawing.Point(51, 449);
			this.newSerialDilutionButton.Name = "newSerialDilutionButton";
			this.newSerialDilutionButton.Size = new System.Drawing.Size(212, 82);
			this.newSerialDilutionButton.TabIndex = 3;
			this.newSerialDilutionButton.Text = "Serial Dilutions";
			this.newSerialDilutionButton.UseVisualStyleBackColor = false;
			this.newSerialDilutionButton.Click += new System.EventHandler(this.NewSerialDilutionButtonClick);
			// 
			// textHeader
			// 
			this.textHeader.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textHeader.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textHeader.Location = new System.Drawing.Point(51, 35);
			this.textHeader.Name = "textHeader";
			this.textHeader.ReadOnly = true;
			this.textHeader.Size = new System.Drawing.Size(442, 30);
			this.textHeader.TabIndex = 4;
			this.textHeader.Text = "Solution and Dilution Calculator";
			// 
			// textDescription
			// 
			this.textDescription.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textDescription.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textDescription.Location = new System.Drawing.Point(51, 87);
			this.textDescription.Multiline = true;
			this.textDescription.Name = "textDescription";
			this.textDescription.ReadOnly = true;
			this.textDescription.Size = new System.Drawing.Size(601, 75);
			this.textDescription.TabIndex = 5;
			this.textDescription.Text = "A simple to use calculator for creating solutions of a pre-determined strength us" +
    "ing reagents and solvents, changing the strength of existing solutions, and guid" +
    "es for serial dilutions.";
			// 
			// newSolutionDescription
			// 
			this.newSolutionDescription.BackColor = System.Drawing.SystemColors.ControlLight;
			this.newSolutionDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.newSolutionDescription.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newSolutionDescription.Location = new System.Drawing.Point(269, 254);
			this.newSolutionDescription.Multiline = true;
			this.newSolutionDescription.Name = "newSolutionDescription";
			this.newSolutionDescription.ReadOnly = true;
			this.newSolutionDescription.Size = new System.Drawing.Size(403, 75);
			this.newSolutionDescription.TabIndex = 6;
			this.newSolutionDescription.Text = "You have a reagent(s), solvent, and need to determine how to create a solution of" +
    " desired strength.";
			// 
			// existingSolutionDescription
			// 
			this.existingSolutionDescription.BackColor = System.Drawing.SystemColors.ControlLight;
			this.existingSolutionDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.existingSolutionDescription.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.existingSolutionDescription.Location = new System.Drawing.Point(269, 359);
			this.existingSolutionDescription.Multiline = true;
			this.existingSolutionDescription.Name = "existingSolutionDescription";
			this.existingSolutionDescription.ReadOnly = true;
			this.existingSolutionDescription.Size = new System.Drawing.Size(403, 69);
			this.existingSolutionDescription.TabIndex = 7;
			this.existingSolutionDescription.Text = "For when you have a solution, and need to change it to a specific concentration o" +
    "r perform a standard dilution.";
			// 
			// serialDilutionDescription
			// 
			this.serialDilutionDescription.BackColor = System.Drawing.SystemColors.ControlLight;
			this.serialDilutionDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.serialDilutionDescription.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serialDilutionDescription.Location = new System.Drawing.Point(269, 456);
			this.serialDilutionDescription.Multiline = true;
			this.serialDilutionDescription.Name = "serialDilutionDescription";
			this.serialDilutionDescription.ReadOnly = true;
			this.serialDilutionDescription.Size = new System.Drawing.Size(403, 69);
			this.serialDilutionDescription.TabIndex = 8;
			this.serialDilutionDescription.Text = "Stepwise dilution of a substance already in solution., resulting in an accurate s" +
    "eries of solutions of known concentrations.";
			// 
			// equationPanelArea
			// 
			this.equationPanelArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.equationPanelArea.BackColor = System.Drawing.SystemColors.MenuBar;
			this.equationPanelArea.Controls.Add(this.serialDilutionEquationsTitle);
			this.equationPanelArea.Controls.Add(this.totalMixingVolumeEquation);
			this.equationPanelArea.Controls.Add(this.totalMixingVolumeLabel);
			this.equationPanelArea.Controls.Add(this.diluentVolumeEquation);
			this.equationPanelArea.Controls.Add(this.diluentVolumeLabel);
			this.equationPanelArea.Controls.Add(this.moveVolumeEquation);
			this.equationPanelArea.Controls.Add(this.moveVolumeLabel);
			this.equationPanelArea.Controls.Add(this.dilutionFactorEquation);
			this.equationPanelArea.Controls.Add(this.dilutionFactorLabel);
			this.equationPanelArea.Controls.Add(this.fixedDilutionEquation);
			this.equationPanelArea.Controls.Add(this.fixedDilutionLabel);
			this.equationPanelArea.Location = new System.Drawing.Point(738, 134);
			this.equationPanelArea.Name = "equationPanelArea";
			this.equationPanelArea.Size = new System.Drawing.Size(430, 439);
			this.equationPanelArea.TabIndex = 9;
			this.equationPanelArea.Visible = false;
			this.equationPanelArea.Paint += new System.Windows.Forms.PaintEventHandler(this.EquationPanelArea_Paint);
			// 
			// serialDilutionEquationsTitle
			// 
			this.serialDilutionEquationsTitle.AutoSize = true;
			this.serialDilutionEquationsTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serialDilutionEquationsTitle.Location = new System.Drawing.Point(33, 177);
			this.serialDilutionEquationsTitle.Name = "serialDilutionEquationsTitle";
			this.serialDilutionEquationsTitle.Size = new System.Drawing.Size(186, 23);
			this.serialDilutionEquationsTitle.TabIndex = 10;
			this.serialDilutionEquationsTitle.Text = "Serial Dilutions:";
			// 
			// totalMixingVolumeEquation
			// 
			this.totalMixingVolumeEquation.AutoSize = true;
			this.totalMixingVolumeEquation.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalMixingVolumeEquation.Location = new System.Drawing.Point(48, 377);
			this.totalMixingVolumeEquation.Name = "totalMixingVolumeEquation";
			this.totalMixingVolumeEquation.Size = new System.Drawing.Size(315, 23);
			this.totalMixingVolumeEquation.TabIndex = 9;
			this.totalMixingVolumeEquation.Text = "Diluent Volume + Move Volume";
			// 
			// totalMixingVolumeLabel
			// 
			this.totalMixingVolumeLabel.AutoSize = true;
			this.totalMixingVolumeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalMixingVolumeLabel.Location = new System.Drawing.Point(33, 354);
			this.totalMixingVolumeLabel.Name = "totalMixingVolumeLabel";
			this.totalMixingVolumeLabel.Size = new System.Drawing.Size(184, 18);
			this.totalMixingVolumeLabel.TabIndex = 8;
			this.totalMixingVolumeLabel.Text = "Total Mixing Volume";
			// 
			// diluentVolumeEquation
			// 
			this.diluentVolumeEquation.AutoSize = true;
			this.diluentVolumeEquation.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.diluentVolumeEquation.Location = new System.Drawing.Point(48, 300);
			this.diluentVolumeEquation.Name = "diluentVolumeEquation";
			this.diluentVolumeEquation.Size = new System.Drawing.Size(285, 23);
			this.diluentVolumeEquation.TabIndex = 7;
			this.diluentVolumeEquation.Text = "Final Volume - Move Volume";
			// 
			// diluentVolumeLabel
			// 
			this.diluentVolumeLabel.AutoSize = true;
			this.diluentVolumeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.diluentVolumeLabel.Location = new System.Drawing.Point(33, 277);
			this.diluentVolumeLabel.Name = "diluentVolumeLabel";
			this.diluentVolumeLabel.Size = new System.Drawing.Size(139, 18);
			this.diluentVolumeLabel.TabIndex = 6;
			this.diluentVolumeLabel.Text = "Diluent Volume";
			// 
			// moveVolumeEquation
			// 
			this.moveVolumeEquation.AutoSize = true;
			this.moveVolumeEquation.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moveVolumeEquation.Location = new System.Drawing.Point(48, 231);
			this.moveVolumeEquation.Name = "moveVolumeEquation";
			this.moveVolumeEquation.Size = new System.Drawing.Size(236, 23);
			this.moveVolumeEquation.TabIndex = 5;
			this.moveVolumeEquation.Text = "Final Volume / (DF - 1)";
			// 
			// moveVolumeLabel
			// 
			this.moveVolumeLabel.AutoSize = true;
			this.moveVolumeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moveVolumeLabel.Location = new System.Drawing.Point(33, 208);
			this.moveVolumeLabel.Name = "moveVolumeLabel";
			this.moveVolumeLabel.Size = new System.Drawing.Size(125, 18);
			this.moveVolumeLabel.TabIndex = 4;
			this.moveVolumeLabel.Text = "Move Volume";
			// 
			// dilutionFactorEquation
			// 
			this.dilutionFactorEquation.AutoSize = true;
			this.dilutionFactorEquation.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dilutionFactorEquation.Location = new System.Drawing.Point(48, 113);
			this.dilutionFactorEquation.Name = "dilutionFactorEquation";
			this.dilutionFactorEquation.Size = new System.Drawing.Size(370, 23);
			this.dilutionFactorEquation.TabIndex = 3;
			this.dilutionFactorEquation.Text = "DF = (Final Volume / Solute Volume)";
			// 
			// dilutionFactorLabel
			// 
			this.dilutionFactorLabel.AutoSize = true;
			this.dilutionFactorLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dilutionFactorLabel.Location = new System.Drawing.Point(33, 89);
			this.dilutionFactorLabel.Name = "dilutionFactorLabel";
			this.dilutionFactorLabel.Size = new System.Drawing.Size(134, 18);
			this.dilutionFactorLabel.TabIndex = 2;
			this.dilutionFactorLabel.Text = "Dilution Factor";
			// 
			// fixedDilutionEquation
			// 
			this.fixedDilutionEquation.AutoSize = true;
			this.fixedDilutionEquation.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fixedDilutionEquation.Location = new System.Drawing.Point(48, 45);
			this.fixedDilutionEquation.Name = "fixedDilutionEquation";
			this.fixedDilutionEquation.Size = new System.Drawing.Size(132, 23);
			this.fixedDilutionEquation.TabIndex = 1;
			this.fixedDilutionEquation.Text = "C₁V₁ = C₂V₂";
			// 
			// fixedDilutionLabel
			// 
			this.fixedDilutionLabel.AutoSize = true;
			this.fixedDilutionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fixedDilutionLabel.Location = new System.Drawing.Point(33, 22);
			this.fixedDilutionLabel.Name = "fixedDilutionLabel";
			this.fixedDilutionLabel.Size = new System.Drawing.Size(125, 18);
			this.fixedDilutionLabel.TabIndex = 0;
			this.fixedDilutionLabel.Text = "Fixed Dilution";
			// 
			// equationButton
			// 
			this.equationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.equationButton.BackColor = System.Drawing.SystemColors.Highlight;
			this.equationButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equationButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.equationButton.Location = new System.Drawing.Point(891, 71);
			this.equationButton.Name = "equationButton";
			this.equationButton.Size = new System.Drawing.Size(125, 54);
			this.equationButton.TabIndex = 10;
			this.equationButton.Text = "Equations";
			this.equationButton.UseVisualStyleBackColor = false;
			this.equationButton.Click += new System.EventHandler(this.EquationButtonClick);
			// 
			// equationPanelBorder
			// 
			this.equationPanelBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.equationPanelBorder.BackColor = System.Drawing.SystemColors.Highlight;
			this.equationPanelBorder.Location = new System.Drawing.Point(736, 132);
			this.equationPanelBorder.Name = "equationPanelBorder";
			this.equationPanelBorder.Size = new System.Drawing.Size(434, 443);
			this.equationPanelBorder.TabIndex = 10;
			this.equationPanelBorder.Visible = false;
			// 
			// newSolutionPanel
			// 
			this.newSolutionPanel.Controls.Add(this.backButton);
			this.newSolutionPanel.Controls.Add(this.newSolutionTitle);
			this.newSolutionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newSolutionPanel.Location = new System.Drawing.Point(0, 0);
			this.newSolutionPanel.Name = "newSolutionPanel";
			this.newSolutionPanel.Size = new System.Drawing.Size(1191, 612);
			this.newSolutionPanel.TabIndex = 11;
			this.newSolutionPanel.Visible = false;
			// 
			// newSolutionTitle
			// 
			this.newSolutionTitle.AutoSize = true;
			this.newSolutionTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newSolutionTitle.Location = new System.Drawing.Point(129, 47);
			this.newSolutionTitle.Name = "newSolutionTitle";
			this.newSolutionTitle.Size = new System.Drawing.Size(311, 29);
			this.newSolutionTitle.TabIndex = 0;
			this.newSolutionTitle.Text = "Create a New Solution";
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.backButton.Image = global::DilutionSolution.Properties.Resources.BackButton;
			this.backButton.Location = new System.Drawing.Point(12, 12);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 64);
			this.backButton.TabIndex = 1;
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// existingSolutionPanel
			// 
			this.existingSolutionPanel.Controls.Add(this.backButton2);
			this.existingSolutionPanel.Controls.Add(this.existingSolutionTitle);
			this.existingSolutionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.existingSolutionPanel.Location = new System.Drawing.Point(0, 0);
			this.existingSolutionPanel.Name = "existingSolutionPanel";
			this.existingSolutionPanel.Size = new System.Drawing.Size(1191, 612);
			this.existingSolutionPanel.TabIndex = 12;
			this.existingSolutionPanel.Visible = false;
			// 
			// backButton2
			// 
			this.backButton2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.backButton2.Image = global::DilutionSolution.Properties.Resources.BackButton;
			this.backButton2.Location = new System.Drawing.Point(12, 12);
			this.backButton2.Name = "backButton2";
			this.backButton2.Size = new System.Drawing.Size(75, 64);
			this.backButton2.TabIndex = 1;
			this.backButton2.UseVisualStyleBackColor = false;
			this.backButton2.Click += new System.EventHandler(this.BackButton2_Click);
			// 
			// existingSolutionTitle
			// 
			this.existingSolutionTitle.AutoSize = true;
			this.existingSolutionTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.existingSolutionTitle.Location = new System.Drawing.Point(129, 47);
			this.existingSolutionTitle.Name = "existingSolutionTitle";
			this.existingSolutionTitle.Size = new System.Drawing.Size(377, 29);
			this.existingSolutionTitle.TabIndex = 0;
			this.existingSolutionTitle.Text = "Modify an Existing Solution";
			// 
			// serialDilutionPanel
			// 
			this.serialDilutionPanel.Controls.Add(this.backButton3);
			this.serialDilutionPanel.Controls.Add(this.serialDilutionTitle);
			this.serialDilutionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.serialDilutionPanel.Location = new System.Drawing.Point(0, 0);
			this.serialDilutionPanel.Name = "serialDilutionPanel";
			this.serialDilutionPanel.Size = new System.Drawing.Size(1191, 612);
			this.serialDilutionPanel.TabIndex = 13;
			this.serialDilutionPanel.Visible = false;
			// 
			// backButton3
			// 
			this.backButton3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.backButton3.Image = global::DilutionSolution.Properties.Resources.BackButton;
			this.backButton3.Location = new System.Drawing.Point(12, 12);
			this.backButton3.Name = "backButton3";
			this.backButton3.Size = new System.Drawing.Size(75, 64);
			this.backButton3.TabIndex = 1;
			this.backButton3.UseVisualStyleBackColor = false;
			this.backButton3.Click += new System.EventHandler(this.BackButton3_Click);
			// 
			// serialDilutionTitle
			// 
			this.serialDilutionTitle.AutoSize = true;
			this.serialDilutionTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serialDilutionTitle.Location = new System.Drawing.Point(129, 47);
			this.serialDilutionTitle.Name = "serialDilutionTitle";
			this.serialDilutionTitle.Size = new System.Drawing.Size(323, 29);
			this.serialDilutionTitle.TabIndex = 0;
			this.serialDilutionTitle.Text = "Create a Serial Dilution";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1191, 612);
			this.Controls.Add(this.serialDilutionPanel);
			this.Controls.Add(this.existingSolutionPanel);
			this.Controls.Add(this.newSolutionPanel);
			this.Controls.Add(this.equationButton);
			this.Controls.Add(this.equationPanelArea);
			this.Controls.Add(this.serialDilutionDescription);
			this.Controls.Add(this.equationPanelBorder);
			this.Controls.Add(this.existingSolutionDescription);
			this.Controls.Add(this.newSolutionDescription);
			this.Controls.Add(this.textDescription);
			this.Controls.Add(this.textHeader);
			this.Controls.Add(this.newSerialDilutionButton);
			this.Controls.Add(this.newDilutionButton);
			this.Controls.Add(this.newSolutionButton);
			this.Controls.Add(this.textSubHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Solution and Dilution Helper";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.equationPanelArea.ResumeLayout(false);
			this.equationPanelArea.PerformLayout();
			this.newSolutionPanel.ResumeLayout(false);
			this.newSolutionPanel.PerformLayout();
			this.existingSolutionPanel.ResumeLayout(false);
			this.existingSolutionPanel.PerformLayout();
			this.serialDilutionPanel.ResumeLayout(false);
			this.serialDilutionPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textSubHeader;
		private System.Windows.Forms.Button newSolutionButton;
		private System.Windows.Forms.Button newDilutionButton;
		private System.Windows.Forms.Button newSerialDilutionButton;
		private System.Windows.Forms.TextBox textHeader;
		private System.Windows.Forms.TextBox textDescription;
		private System.Windows.Forms.TextBox newSolutionDescription;
		private System.Windows.Forms.TextBox existingSolutionDescription;
		private System.Windows.Forms.TextBox serialDilutionDescription;
		private System.Windows.Forms.Panel equationPanelArea;
		private System.Windows.Forms.Button equationButton;
		private System.Windows.Forms.Panel equationPanelBorder;
		private System.Windows.Forms.Label fixedDilutionLabel;
		private System.Windows.Forms.Label fixedDilutionEquation;
		private System.Windows.Forms.Label totalMixingVolumeEquation;
		private System.Windows.Forms.Label totalMixingVolumeLabel;
		private System.Windows.Forms.Label diluentVolumeEquation;
		private System.Windows.Forms.Label diluentVolumeLabel;
		private System.Windows.Forms.Label moveVolumeEquation;
		private System.Windows.Forms.Label moveVolumeLabel;
		private System.Windows.Forms.Label dilutionFactorEquation;
		private System.Windows.Forms.Label dilutionFactorLabel;
		private System.Windows.Forms.Label serialDilutionEquationsTitle;
		private System.Windows.Forms.Panel newSolutionPanel;
		private System.Windows.Forms.Label newSolutionTitle;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Panel existingSolutionPanel;
		private System.Windows.Forms.Button backButton2;
		private System.Windows.Forms.Label existingSolutionTitle;
		private System.Windows.Forms.Panel serialDilutionPanel;
		private System.Windows.Forms.Button backButton3;
		private System.Windows.Forms.Label serialDilutionTitle;
	}
}

