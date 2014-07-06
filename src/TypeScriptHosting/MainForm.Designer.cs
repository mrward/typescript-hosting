// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

namespace TypeScriptHosting
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.memberCompletionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.completionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signatureCompletionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.typescriptTabPage = new System.Windows.Forms.TabPage();
			this.scriptTextBox = new System.Windows.Forms.RichTextBox();
			this.javascriptTabPage = new System.Windows.Forms.TabPage();
			this.adhocJavascriptTextBox = new System.Windows.Forms.RichTextBox();
			this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.typescriptTabPage.SuspendLayout();
			this.javascriptTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(748, 24);
			this.mainMenuStrip.TabIndex = 2;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.runToolStripMenuItem,
									this.memberCompletionToolStripMenuItem,
									this.completionToolStripMenuItem,
									this.signatureCompletionToolStripMenuItem,
									this.compileToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.runToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.runToolStripMenuItem.Text = "&Run";
			this.runToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItemClick);
			// 
			// memberCompletionToolStripMenuItem
			// 
			this.memberCompletionToolStripMenuItem.Name = "memberCompletionToolStripMenuItem";
			this.memberCompletionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.memberCompletionToolStripMenuItem.Text = "&Member Completion";
			this.memberCompletionToolStripMenuItem.Click += new System.EventHandler(this.MemberCompletionToolStripMenuItemClick);
			// 
			// completionToolStripMenuItem
			// 
			this.completionToolStripMenuItem.Name = "completionToolStripMenuItem";
			this.completionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.completionToolStripMenuItem.Text = "&Completion";
			this.completionToolStripMenuItem.Click += new System.EventHandler(this.CompletionToolStripMenuItemClick);
			// 
			// signatureCompletionToolStripMenuItem
			// 
			this.signatureCompletionToolStripMenuItem.Name = "signatureCompletionToolStripMenuItem";
			this.signatureCompletionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.signatureCompletionToolStripMenuItem.Text = "&Signature Completion";
			this.signatureCompletionToolStripMenuItem.Click += new System.EventHandler(this.SignatureCompletionToolStripMenuItemClick);
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.typescriptTabPage);
			this.tabControl.Controls.Add(this.javascriptTabPage);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(748, 406);
			this.tabControl.TabIndex = 3;
			// 
			// typescriptTabPage
			// 
			this.typescriptTabPage.Controls.Add(this.scriptTextBox);
			this.typescriptTabPage.Location = new System.Drawing.Point(4, 22);
			this.typescriptTabPage.Name = "typescriptTabPage";
			this.typescriptTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.typescriptTabPage.Size = new System.Drawing.Size(740, 380);
			this.typescriptTabPage.TabIndex = 0;
			this.typescriptTabPage.Text = "Typescript";
			this.typescriptTabPage.UseVisualStyleBackColor = true;
			// 
			// scriptTextBox
			// 
			this.scriptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scriptTextBox.Location = new System.Drawing.Point(3, 3);
			this.scriptTextBox.Name = "scriptTextBox";
			this.scriptTextBox.Size = new System.Drawing.Size(734, 374);
			this.scriptTextBox.TabIndex = 2;
			this.scriptTextBox.Text = "";
			this.scriptTextBox.TextChanged += new System.EventHandler(this.ScriptTextBoxTextChanged);
			// 
			// javascriptTabPage
			// 
			this.javascriptTabPage.Controls.Add(this.adhocJavascriptTextBox);
			this.javascriptTabPage.Location = new System.Drawing.Point(4, 22);
			this.javascriptTabPage.Name = "javascriptTabPage";
			this.javascriptTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.javascriptTabPage.Size = new System.Drawing.Size(740, 380);
			this.javascriptTabPage.TabIndex = 1;
			this.javascriptTabPage.Text = "Adhoc Javascript";
			this.javascriptTabPage.UseVisualStyleBackColor = true;
			// 
			// adhocJavascriptTextBox
			// 
			this.adhocJavascriptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.adhocJavascriptTextBox.Location = new System.Drawing.Point(3, 3);
			this.adhocJavascriptTextBox.Name = "adhocJavascriptTextBox";
			this.adhocJavascriptTextBox.Size = new System.Drawing.Size(734, 374);
			this.adhocJavascriptTextBox.TabIndex = 3;
			this.adhocJavascriptTextBox.Text = "ls.refresh(true);\nvar sig = ls.getSignatureAtPosition(host.FileName, host.getPosi" +
			"tion());\nhost.log(sig);";
			// 
			// compileToolStripMenuItem
			// 
			this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
			this.compileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.compileToolStripMenuItem.Text = "Com&pile";
			this.compileToolStripMenuItem.Click += new System.EventHandler(this.CompileToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 430);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.Text = "TypeScriptHosting";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.typescriptTabPage.ResumeLayout(false);
			this.javascriptTabPage.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signatureCompletionToolStripMenuItem;
		private System.Windows.Forms.RichTextBox adhocJavascriptTextBox;
		private System.Windows.Forms.TabPage javascriptTabPage;
		private System.Windows.Forms.TabPage typescriptTabPage;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.ToolStripMenuItem completionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem memberCompletionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.RichTextBox scriptTextBox;
	}
}
