namespace EmojiLib
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControlEmojis = new System.Windows.Forms.TabControl();
			this.tabPageSmileys = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonGrinningFace = new System.Windows.Forms.Button();
			this.buttonGrinningFaceWithBigEyes = new System.Windows.Forms.Button();
			this.buttonGrinningFaceWithSmilingEyes = new System.Windows.Forms.Button();
			this.buttonBeamingFaceWithSmilingEyes = new System.Windows.Forms.Button();
			this.buttonGrinningSquintingFace = new System.Windows.Forms.Button();
			this.buttonGrinningFaceWithSweat = new System.Windows.Forms.Button();
			this.buttonRollingOnTheFloorLaughing = new System.Windows.Forms.Button();
			this.buttonFaceWithTearsOfJoy = new System.Windows.Forms.Button();
			this.buttonSlightlySmilingFace = new System.Windows.Forms.Button();
			this.buttonUpsideDownFace = new System.Windows.Forms.Button();
			this.buttonWinkingFace = new System.Windows.Forms.Button();
			this.buttonSmilingFaceWithSmilingEyes = new System.Windows.Forms.Button();
			this.buttonSmilingFaceWithHalo = new System.Windows.Forms.Button();
			this.tabControlEmojis.SuspendLayout();
			this.tabPageSmileys.SuspendLayout();
			this.flowLayoutPanel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlEmojis
			// 
			this.tabControlEmojis.Controls.Add(this.tabPageSmileys);
			this.tabControlEmojis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlEmojis.Location = new System.Drawing.Point(0, 0);
			this.tabControlEmojis.Name = "tabControlEmojis";
			this.tabControlEmojis.SelectedIndex = 0;
			this.tabControlEmojis.ShowToolTips = true;
			this.tabControlEmojis.Size = new System.Drawing.Size(351, 305);
			this.tabControlEmojis.TabIndex = 0;
			// 
			// tabPageSmileys
			// 
			this.tabPageSmileys.AutoScroll = true;
			this.tabPageSmileys.Controls.Add(this.flowLayoutPanel);
			this.tabPageSmileys.Location = new System.Drawing.Point(4, 22);
			this.tabPageSmileys.Name = "tabPageSmileys";
			this.tabPageSmileys.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSmileys.Size = new System.Drawing.Size(343, 279);
			this.tabPageSmileys.TabIndex = 0;
			this.tabPageSmileys.Text = "Smileys";
			this.tabPageSmileys.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AutoScroll = true;
			this.flowLayoutPanel.Controls.Add(this.buttonGrinningFace);
			this.flowLayoutPanel.Controls.Add(this.buttonGrinningFaceWithBigEyes);
			this.flowLayoutPanel.Controls.Add(this.buttonGrinningFaceWithSmilingEyes);
			this.flowLayoutPanel.Controls.Add(this.buttonBeamingFaceWithSmilingEyes);
			this.flowLayoutPanel.Controls.Add(this.buttonGrinningSquintingFace);
			this.flowLayoutPanel.Controls.Add(this.buttonGrinningFaceWithSweat);
			this.flowLayoutPanel.Controls.Add(this.buttonRollingOnTheFloorLaughing);
			this.flowLayoutPanel.Controls.Add(this.buttonFaceWithTearsOfJoy);
			this.flowLayoutPanel.Controls.Add(this.buttonSlightlySmilingFace);
			this.flowLayoutPanel.Controls.Add(this.buttonUpsideDownFace);
			this.flowLayoutPanel.Controls.Add(this.buttonWinkingFace);
			this.flowLayoutPanel.Controls.Add(this.buttonSmilingFaceWithSmilingEyes);
			this.flowLayoutPanel.Controls.Add(this.buttonSmilingFaceWithHalo);
			this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(337, 273);
			this.flowLayoutPanel.TabIndex = 1;
			this.flowLayoutPanel.TabStop = true;
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(351, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelInformation
			// 
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(25, 17);
			this.labelInformation.Text = "info";
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.tabControlEmojis);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(351, 305);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(351, 351);
			this.toolStripContainer.TabIndex = 2;
			this.toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip.ShowItemToolTips = true;
			this.menuStrip.Size = new System.Drawing.Size(351, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// toolStripMenuItemFile
			// 
			this.toolStripMenuItemFile.AutoToolTip = true;
			this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
			this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			this.toolStripMenuItemFile.Size = new System.Drawing.Size(35, 20);
			this.toolStripMenuItemFile.Text = "&File";
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.AutoToolTip = true;
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(92, 22);
			this.toolStripMenuItemExit.Text = "&Exit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// buttonGrinningFace
			// 
			this.buttonGrinningFace.AccessibleDescription = "grinning face";
			this.buttonGrinningFace.AccessibleName = "grinning face";
			this.buttonGrinningFace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonGrinningFace.BackgroundImage = global::EmojiLib.Properties.Resources.GrinningFaceGoogle;
			this.buttonGrinningFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonGrinningFace.FlatAppearance.BorderSize = 0;
			this.buttonGrinningFace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonGrinningFace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonGrinningFace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonGrinningFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGrinningFace.Location = new System.Drawing.Point(0, 0);
			this.buttonGrinningFace.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGrinningFace.Name = "buttonGrinningFace";
			this.buttonGrinningFace.Size = new System.Drawing.Size(32, 32);
			this.buttonGrinningFace.TabIndex = 0;
			this.toolTip.SetToolTip(this.buttonGrinningFace, "grinning face");
			this.buttonGrinningFace.UseVisualStyleBackColor = true;
			this.buttonGrinningFace.Click += new System.EventHandler(this.ButtonGrinningFace_Click);
			this.buttonGrinningFace.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningFace.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonGrinningFace.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningFace.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonGrinningFaceWithBigEyes
			// 
			this.buttonGrinningFaceWithBigEyes.AccessibleDescription = "grinning face with big eyes";
			this.buttonGrinningFaceWithBigEyes.AccessibleName = "grinning face with big eyes";
			this.buttonGrinningFaceWithBigEyes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonGrinningFaceWithBigEyes.BackgroundImage = global::EmojiLib.Properties.Resources.GrinningFaceWithBigEyesGoogle;
			this.buttonGrinningFaceWithBigEyes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonGrinningFaceWithBigEyes.FlatAppearance.BorderSize = 0;
			this.buttonGrinningFaceWithBigEyes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonGrinningFaceWithBigEyes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonGrinningFaceWithBigEyes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonGrinningFaceWithBigEyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGrinningFaceWithBigEyes.Location = new System.Drawing.Point(32, 0);
			this.buttonGrinningFaceWithBigEyes.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGrinningFaceWithBigEyes.Name = "buttonGrinningFaceWithBigEyes";
			this.buttonGrinningFaceWithBigEyes.Size = new System.Drawing.Size(32, 32);
			this.buttonGrinningFaceWithBigEyes.TabIndex = 1;
			this.toolTip.SetToolTip(this.buttonGrinningFaceWithBigEyes, "grinning face with big eyes");
			this.buttonGrinningFaceWithBigEyes.UseVisualStyleBackColor = true;
			this.buttonGrinningFaceWithBigEyes.Click += new System.EventHandler(this.ButtonGrinningFaceWithBigEyes_Click);
			this.buttonGrinningFaceWithBigEyes.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningFaceWithBigEyes.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonGrinningFaceWithBigEyes.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningFaceWithBigEyes.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonGrinningFaceWithSmilingEyes
			// 
			this.buttonGrinningFaceWithSmilingEyes.AccessibleDescription = "grinning face with smiling eyes";
			this.buttonGrinningFaceWithSmilingEyes.AccessibleName = "grinning face with smiling eyes";
			this.buttonGrinningFaceWithSmilingEyes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonGrinningFaceWithSmilingEyes.BackgroundImage = global::EmojiLib.Properties.Resources.GrinningFaceWithSmilingEyesGoogle;
			this.buttonGrinningFaceWithSmilingEyes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonGrinningFaceWithSmilingEyes.FlatAppearance.BorderSize = 0;
			this.buttonGrinningFaceWithSmilingEyes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonGrinningFaceWithSmilingEyes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonGrinningFaceWithSmilingEyes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonGrinningFaceWithSmilingEyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGrinningFaceWithSmilingEyes.Location = new System.Drawing.Point(64, 0);
			this.buttonGrinningFaceWithSmilingEyes.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGrinningFaceWithSmilingEyes.Name = "buttonGrinningFaceWithSmilingEyes";
			this.buttonGrinningFaceWithSmilingEyes.Size = new System.Drawing.Size(32, 32);
			this.buttonGrinningFaceWithSmilingEyes.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonGrinningFaceWithSmilingEyes, "grinning face with smiling eyes");
			this.buttonGrinningFaceWithSmilingEyes.UseVisualStyleBackColor = true;
			this.buttonGrinningFaceWithSmilingEyes.Click += new System.EventHandler(this.ButtonGrinningFaceWithSmilingEyes_Click);
			this.buttonGrinningFaceWithSmilingEyes.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningFaceWithSmilingEyes.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonGrinningFaceWithSmilingEyes.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningFaceWithSmilingEyes.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonBeamingFaceWithSmilingEyes
			// 
			this.buttonBeamingFaceWithSmilingEyes.AccessibleDescription = "beaming face with smiling eyes";
			this.buttonBeamingFaceWithSmilingEyes.AccessibleName = "beaming face with smiling eyes";
			this.buttonBeamingFaceWithSmilingEyes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonBeamingFaceWithSmilingEyes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBeamingFaceWithSmilingEyes.BackgroundImage")));
			this.buttonBeamingFaceWithSmilingEyes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonBeamingFaceWithSmilingEyes.FlatAppearance.BorderSize = 0;
			this.buttonBeamingFaceWithSmilingEyes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonBeamingFaceWithSmilingEyes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonBeamingFaceWithSmilingEyes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonBeamingFaceWithSmilingEyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBeamingFaceWithSmilingEyes.Location = new System.Drawing.Point(96, 0);
			this.buttonBeamingFaceWithSmilingEyes.Margin = new System.Windows.Forms.Padding(0);
			this.buttonBeamingFaceWithSmilingEyes.Name = "buttonBeamingFaceWithSmilingEyes";
			this.buttonBeamingFaceWithSmilingEyes.Size = new System.Drawing.Size(32, 32);
			this.buttonBeamingFaceWithSmilingEyes.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonBeamingFaceWithSmilingEyes, "beaming face with smiling eyes");
			this.buttonBeamingFaceWithSmilingEyes.UseVisualStyleBackColor = true;
			this.buttonBeamingFaceWithSmilingEyes.Click += new System.EventHandler(this.ButtonBeamingFaceWithSmilingEyes_Click);
			this.buttonBeamingFaceWithSmilingEyes.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonBeamingFaceWithSmilingEyes.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonBeamingFaceWithSmilingEyes.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonBeamingFaceWithSmilingEyes.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonGrinningSquintingFace
			// 
			this.buttonGrinningSquintingFace.AccessibleDescription = "grinning squinting face";
			this.buttonGrinningSquintingFace.AccessibleName = "grinning squinting face";
			this.buttonGrinningSquintingFace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonGrinningSquintingFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGrinningSquintingFace.BackgroundImage")));
			this.buttonGrinningSquintingFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonGrinningSquintingFace.FlatAppearance.BorderSize = 0;
			this.buttonGrinningSquintingFace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonGrinningSquintingFace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonGrinningSquintingFace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonGrinningSquintingFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGrinningSquintingFace.Location = new System.Drawing.Point(128, 0);
			this.buttonGrinningSquintingFace.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGrinningSquintingFace.Name = "buttonGrinningSquintingFace";
			this.buttonGrinningSquintingFace.Size = new System.Drawing.Size(32, 32);
			this.buttonGrinningSquintingFace.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonGrinningSquintingFace, "grinning squinting face");
			this.buttonGrinningSquintingFace.UseVisualStyleBackColor = true;
			this.buttonGrinningSquintingFace.Click += new System.EventHandler(this.ButtonGrinningSquintingFace_Click);
			this.buttonGrinningSquintingFace.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningSquintingFace.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonGrinningSquintingFace.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningSquintingFace.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonGrinningFaceWithSweat
			// 
			this.buttonGrinningFaceWithSweat.AccessibleDescription = "grinning face with sweat";
			this.buttonGrinningFaceWithSweat.AccessibleName = "grinning face with sweat";
			this.buttonGrinningFaceWithSweat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonGrinningFaceWithSweat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGrinningFaceWithSweat.BackgroundImage")));
			this.buttonGrinningFaceWithSweat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonGrinningFaceWithSweat.FlatAppearance.BorderSize = 0;
			this.buttonGrinningFaceWithSweat.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonGrinningFaceWithSweat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonGrinningFaceWithSweat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonGrinningFaceWithSweat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGrinningFaceWithSweat.Location = new System.Drawing.Point(160, 0);
			this.buttonGrinningFaceWithSweat.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGrinningFaceWithSweat.Name = "buttonGrinningFaceWithSweat";
			this.buttonGrinningFaceWithSweat.Size = new System.Drawing.Size(32, 32);
			this.buttonGrinningFaceWithSweat.TabIndex = 5;
			this.toolTip.SetToolTip(this.buttonGrinningFaceWithSweat, "grinning face with sweat");
			this.buttonGrinningFaceWithSweat.UseVisualStyleBackColor = true;
			this.buttonGrinningFaceWithSweat.Click += new System.EventHandler(this.ButtonGrinningFaceWithSweat_Click);
			this.buttonGrinningFaceWithSweat.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningFaceWithSweat.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonGrinningFaceWithSweat.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonGrinningFaceWithSweat.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonRollingOnTheFloorLaughing
			// 
			this.buttonRollingOnTheFloorLaughing.AccessibleDescription = "rolling on the floor laughing";
			this.buttonRollingOnTheFloorLaughing.AccessibleName = "rolling on the floor laughing";
			this.buttonRollingOnTheFloorLaughing.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonRollingOnTheFloorLaughing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRollingOnTheFloorLaughing.BackgroundImage")));
			this.buttonRollingOnTheFloorLaughing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRollingOnTheFloorLaughing.FlatAppearance.BorderSize = 0;
			this.buttonRollingOnTheFloorLaughing.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonRollingOnTheFloorLaughing.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonRollingOnTheFloorLaughing.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonRollingOnTheFloorLaughing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRollingOnTheFloorLaughing.Location = new System.Drawing.Point(192, 0);
			this.buttonRollingOnTheFloorLaughing.Margin = new System.Windows.Forms.Padding(0);
			this.buttonRollingOnTheFloorLaughing.Name = "buttonRollingOnTheFloorLaughing";
			this.buttonRollingOnTheFloorLaughing.Size = new System.Drawing.Size(32, 32);
			this.buttonRollingOnTheFloorLaughing.TabIndex = 6;
			this.toolTip.SetToolTip(this.buttonRollingOnTheFloorLaughing, "rolling on the floor laughing");
			this.buttonRollingOnTheFloorLaughing.UseVisualStyleBackColor = true;
			this.buttonRollingOnTheFloorLaughing.Click += new System.EventHandler(this.ButtonRollingOnTheFloorLaughing_Click);
			this.buttonRollingOnTheFloorLaughing.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonRollingOnTheFloorLaughing.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonRollingOnTheFloorLaughing.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonRollingOnTheFloorLaughing.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonFaceWithTearsOfJoy
			// 
			this.buttonFaceWithTearsOfJoy.AccessibleDescription = "face with tears of joy";
			this.buttonFaceWithTearsOfJoy.AccessibleName = "face with tears of joy";
			this.buttonFaceWithTearsOfJoy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonFaceWithTearsOfJoy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFaceWithTearsOfJoy.BackgroundImage")));
			this.buttonFaceWithTearsOfJoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonFaceWithTearsOfJoy.FlatAppearance.BorderSize = 0;
			this.buttonFaceWithTearsOfJoy.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonFaceWithTearsOfJoy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonFaceWithTearsOfJoy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonFaceWithTearsOfJoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFaceWithTearsOfJoy.Location = new System.Drawing.Point(224, 0);
			this.buttonFaceWithTearsOfJoy.Margin = new System.Windows.Forms.Padding(0);
			this.buttonFaceWithTearsOfJoy.Name = "buttonFaceWithTearsOfJoy";
			this.buttonFaceWithTearsOfJoy.Size = new System.Drawing.Size(32, 32);
			this.buttonFaceWithTearsOfJoy.TabIndex = 7;
			this.toolTip.SetToolTip(this.buttonFaceWithTearsOfJoy, "face with tears of joy");
			this.buttonFaceWithTearsOfJoy.UseVisualStyleBackColor = true;
			this.buttonFaceWithTearsOfJoy.Click += new System.EventHandler(this.ButtonFaceWithTearsOfJoy_Click);
			this.buttonFaceWithTearsOfJoy.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonFaceWithTearsOfJoy.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonFaceWithTearsOfJoy.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonFaceWithTearsOfJoy.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSlightlySmilingFace
			// 
			this.buttonSlightlySmilingFace.AccessibleDescription = "slightly smiling face";
			this.buttonSlightlySmilingFace.AccessibleName = "slightly smiling face";
			this.buttonSlightlySmilingFace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSlightlySmilingFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSlightlySmilingFace.BackgroundImage")));
			this.buttonSlightlySmilingFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonSlightlySmilingFace.FlatAppearance.BorderSize = 0;
			this.buttonSlightlySmilingFace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonSlightlySmilingFace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSlightlySmilingFace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonSlightlySmilingFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSlightlySmilingFace.Location = new System.Drawing.Point(256, 0);
			this.buttonSlightlySmilingFace.Margin = new System.Windows.Forms.Padding(0);
			this.buttonSlightlySmilingFace.Name = "buttonSlightlySmilingFace";
			this.buttonSlightlySmilingFace.Size = new System.Drawing.Size(32, 32);
			this.buttonSlightlySmilingFace.TabIndex = 8;
			this.toolTip.SetToolTip(this.buttonSlightlySmilingFace, "slightly smiling face");
			this.buttonSlightlySmilingFace.UseVisualStyleBackColor = true;
			this.buttonSlightlySmilingFace.Click += new System.EventHandler(this.ButtonSlightlySmilingFace_Click);
			this.buttonSlightlySmilingFace.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSlightlySmilingFace.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSlightlySmilingFace.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSlightlySmilingFace.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonUpsideDownFace
			// 
			this.buttonUpsideDownFace.AccessibleDescription = "upside-down face";
			this.buttonUpsideDownFace.AccessibleName = "upside-down face";
			this.buttonUpsideDownFace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonUpsideDownFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpsideDownFace.BackgroundImage")));
			this.buttonUpsideDownFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUpsideDownFace.FlatAppearance.BorderSize = 0;
			this.buttonUpsideDownFace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonUpsideDownFace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonUpsideDownFace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonUpsideDownFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUpsideDownFace.Location = new System.Drawing.Point(288, 0);
			this.buttonUpsideDownFace.Margin = new System.Windows.Forms.Padding(0);
			this.buttonUpsideDownFace.Name = "buttonUpsideDownFace";
			this.buttonUpsideDownFace.Size = new System.Drawing.Size(32, 32);
			this.buttonUpsideDownFace.TabIndex = 9;
			this.toolTip.SetToolTip(this.buttonUpsideDownFace, "upside-down face");
			this.buttonUpsideDownFace.UseVisualStyleBackColor = true;
			this.buttonUpsideDownFace.Click += new System.EventHandler(this.ButtonUpsideDownFace_Click);
			this.buttonUpsideDownFace.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonUpsideDownFace.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonUpsideDownFace.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonUpsideDownFace.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonWinkingFace
			// 
			this.buttonWinkingFace.AccessibleDescription = "winking face";
			this.buttonWinkingFace.AccessibleName = "winking face";
			this.buttonWinkingFace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonWinkingFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWinkingFace.BackgroundImage")));
			this.buttonWinkingFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonWinkingFace.FlatAppearance.BorderSize = 0;
			this.buttonWinkingFace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonWinkingFace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonWinkingFace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonWinkingFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonWinkingFace.Location = new System.Drawing.Point(0, 32);
			this.buttonWinkingFace.Margin = new System.Windows.Forms.Padding(0);
			this.buttonWinkingFace.Name = "buttonWinkingFace";
			this.buttonWinkingFace.Size = new System.Drawing.Size(32, 32);
			this.buttonWinkingFace.TabIndex = 10;
			this.toolTip.SetToolTip(this.buttonWinkingFace, "winking face");
			this.buttonWinkingFace.UseVisualStyleBackColor = true;
			this.buttonWinkingFace.Click += new System.EventHandler(this.ButtonWinkingFace_Click);
			this.buttonWinkingFace.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonWinkingFace.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonWinkingFace.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonWinkingFace.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSmilingFaceWithSmilingEyes
			// 
			this.buttonSmilingFaceWithSmilingEyes.AccessibleDescription = "smiling face with smiling eyes";
			this.buttonSmilingFaceWithSmilingEyes.AccessibleName = "smiling face with smiling eyes";
			this.buttonSmilingFaceWithSmilingEyes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSmilingFaceWithSmilingEyes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSmilingFaceWithSmilingEyes.BackgroundImage")));
			this.buttonSmilingFaceWithSmilingEyes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonSmilingFaceWithSmilingEyes.FlatAppearance.BorderSize = 0;
			this.buttonSmilingFaceWithSmilingEyes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonSmilingFaceWithSmilingEyes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSmilingFaceWithSmilingEyes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonSmilingFaceWithSmilingEyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSmilingFaceWithSmilingEyes.Location = new System.Drawing.Point(32, 32);
			this.buttonSmilingFaceWithSmilingEyes.Margin = new System.Windows.Forms.Padding(0);
			this.buttonSmilingFaceWithSmilingEyes.Name = "buttonSmilingFaceWithSmilingEyes";
			this.buttonSmilingFaceWithSmilingEyes.Size = new System.Drawing.Size(32, 32);
			this.buttonSmilingFaceWithSmilingEyes.TabIndex = 11;
			this.toolTip.SetToolTip(this.buttonSmilingFaceWithSmilingEyes, "smiling face with smiling eyes");
			this.buttonSmilingFaceWithSmilingEyes.UseVisualStyleBackColor = true;
			this.buttonSmilingFaceWithSmilingEyes.Click += new System.EventHandler(this.ButtonSmilingFaceWithSmilingEyes_Click);
			this.buttonSmilingFaceWithSmilingEyes.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSmilingFaceWithSmilingEyes.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSmilingFaceWithSmilingEyes.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSmilingFaceWithSmilingEyes.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSmilingFaceWithHalo
			// 
			this.buttonSmilingFaceWithHalo.AccessibleDescription = "smiling face with halo";
			this.buttonSmilingFaceWithHalo.AccessibleName = "smiling face with halo";
			this.buttonSmilingFaceWithHalo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSmilingFaceWithHalo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSmilingFaceWithHalo.BackgroundImage")));
			this.buttonSmilingFaceWithHalo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonSmilingFaceWithHalo.FlatAppearance.BorderSize = 0;
			this.buttonSmilingFaceWithHalo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonSmilingFaceWithHalo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSmilingFaceWithHalo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.buttonSmilingFaceWithHalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSmilingFaceWithHalo.Location = new System.Drawing.Point(64, 32);
			this.buttonSmilingFaceWithHalo.Margin = new System.Windows.Forms.Padding(0);
			this.buttonSmilingFaceWithHalo.Name = "buttonSmilingFaceWithHalo";
			this.buttonSmilingFaceWithHalo.Size = new System.Drawing.Size(32, 32);
			this.buttonSmilingFaceWithHalo.TabIndex = 12;
			this.toolTip.SetToolTip(this.buttonSmilingFaceWithHalo, "smiling face with halo");
			this.buttonSmilingFaceWithHalo.UseVisualStyleBackColor = true;
			this.buttonSmilingFaceWithHalo.Click += new System.EventHandler(this.ButtonSmilingFaceWithHalo_Click);
			this.buttonSmilingFaceWithHalo.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSmilingFaceWithHalo.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSmilingFaceWithHalo.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSmilingFaceWithHalo.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 351);
			this.Controls.Add(this.toolStripContainer);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Emoji Lib";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControlEmojis.ResumeLayout(false);
			this.tabPageSmileys.ResumeLayout(false);
			this.flowLayoutPanel.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlEmojis;
		private System.Windows.Forms.TabPage tabPageSmileys;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.Button buttonGrinningFace;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.Button buttonGrinningFaceWithBigEyes;
		private System.Windows.Forms.Button buttonGrinningFaceWithSmilingEyes;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.Button buttonBeamingFaceWithSmilingEyes;
		private System.Windows.Forms.Button buttonGrinningSquintingFace;
		private System.Windows.Forms.Button buttonGrinningFaceWithSweat;
		private System.Windows.Forms.Button buttonRollingOnTheFloorLaughing;
		private System.Windows.Forms.Button buttonFaceWithTearsOfJoy;
		private System.Windows.Forms.Button buttonSlightlySmilingFace;
		private System.Windows.Forms.Button buttonUpsideDownFace;
		private System.Windows.Forms.Button buttonWinkingFace;
		private System.Windows.Forms.Button buttonSmilingFaceWithSmilingEyes;
		private System.Windows.Forms.Button buttonSmilingFaceWithHalo;
	}
}

