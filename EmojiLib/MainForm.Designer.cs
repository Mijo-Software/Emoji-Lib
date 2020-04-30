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
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonGrinningFace = new System.Windows.Forms.Button();
			this.buttonGrinningFaceWithBigEyes = new System.Windows.Forms.Button();
			this.buttonGrinningFaceWithSmilingEyes = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tabControlEmojis.SuspendLayout();
			this.tabPageSmileys.SuspendLayout();
			this.flowLayoutPanel.SuspendLayout();
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
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(351, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
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
			this.buttonGrinningFace.BackgroundImage = global::EmojiLib.Properties.Resources.GrinningFaceGoogle;
			this.buttonGrinningFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonGrinningFace.FlatAppearance.BorderSize = 0;
			this.buttonGrinningFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGrinningFace.Location = new System.Drawing.Point(0, 0);
			this.buttonGrinningFace.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGrinningFace.Name = "buttonGrinningFace";
			this.buttonGrinningFace.Size = new System.Drawing.Size(32, 32);
			this.buttonGrinningFace.TabIndex = 0;
			this.toolTip.SetToolTip(this.buttonGrinningFace, "grinning face");
			this.buttonGrinningFace.UseVisualStyleBackColor = true;
			this.buttonGrinningFace.Click += new System.EventHandler(this.ButtonGrinningFace_Click);
			// 
			// buttonGrinningFaceWithBigEyes
			// 
			this.buttonGrinningFaceWithBigEyes.BackgroundImage = global::EmojiLib.Properties.Resources.GrinningFaceWithBigEyesGoogle;
			this.buttonGrinningFaceWithBigEyes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonGrinningFaceWithBigEyes.FlatAppearance.BorderSize = 0;
			this.buttonGrinningFaceWithBigEyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGrinningFaceWithBigEyes.Location = new System.Drawing.Point(32, 0);
			this.buttonGrinningFaceWithBigEyes.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGrinningFaceWithBigEyes.Name = "buttonGrinningFaceWithBigEyes";
			this.buttonGrinningFaceWithBigEyes.Size = new System.Drawing.Size(32, 32);
			this.buttonGrinningFaceWithBigEyes.TabIndex = 1;
			this.toolTip.SetToolTip(this.buttonGrinningFaceWithBigEyes, "grinning face with big eyes");
			this.buttonGrinningFaceWithBigEyes.UseVisualStyleBackColor = true;
			this.buttonGrinningFaceWithBigEyes.Click += new System.EventHandler(this.ButtonGrinningFaceWithBigEyes_Click);
			// 
			// buttonGrinningFaceWithSmilingEyes
			// 
			this.buttonGrinningFaceWithSmilingEyes.BackgroundImage = global::EmojiLib.Properties.Resources.GrinningFaceWithSmilingEyesGoogle;
			this.buttonGrinningFaceWithSmilingEyes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonGrinningFaceWithSmilingEyes.FlatAppearance.BorderSize = 0;
			this.buttonGrinningFaceWithSmilingEyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGrinningFaceWithSmilingEyes.Location = new System.Drawing.Point(64, 0);
			this.buttonGrinningFaceWithSmilingEyes.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGrinningFaceWithSmilingEyes.Name = "buttonGrinningFaceWithSmilingEyes";
			this.buttonGrinningFaceWithSmilingEyes.Size = new System.Drawing.Size(32, 32);
			this.buttonGrinningFaceWithSmilingEyes.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonGrinningFaceWithSmilingEyes, "grinning face with smiling eyes");
			this.buttonGrinningFaceWithSmilingEyes.UseVisualStyleBackColor = true;
			this.buttonGrinningFaceWithSmilingEyes.Click += new System.EventHandler(this.ButtonGrinningFaceWithSmilingEyes_Click);
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
			this.tabControlEmojis.ResumeLayout(false);
			this.tabPageSmileys.ResumeLayout(false);
			this.flowLayoutPanel.ResumeLayout(false);
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
	}
}

