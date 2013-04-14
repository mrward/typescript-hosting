// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Noesis.Javascript;

namespace TypeScriptHosting
{
	public partial class MainForm : Form
	{
		JavascriptContext context;
		LanguageServiceShimHost host;
		
		public MainForm()
		{
			InitializeComponent();
			Init();
		}
		
		void Init()
		{
			try {
				context = new JavascriptContext();
				host = new LanguageServiceShimHost();
				context.SetParameter("host", host);
				
				//host.AddFile("lib.d.ts", File.ReadAllText("lib.d.ts"));
				
				string source = File.ReadAllText("typescriptServices.js");
				context.Run(source);
				
				source = File.ReadAllText("test.ts");
				scriptTextBox.Text = source;
				
				string fileName = "Main.js";
				host.AddFile(fileName, source);
				host.FileName = fileName;
				
				source = File.ReadAllText("Main.js");
				context.Run(source);
				
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
			}
		}
		
		void RunToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
				host.Position = scriptTextBox.SelectionStart;
				context.Run(adhocJavascriptTextBox.Text);
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
			}
		}
		
		void MemberCompletionToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
				host.Position = scriptTextBox.SelectionStart;
				string source = File.ReadAllText("MemberCompletion.js");
				context.Run(source);
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
			}
		}
		
		void CompletionToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
				host.Position = scriptTextBox.SelectionStart;
				string source = File.ReadAllText("Completion.js");
				context.Run(source);
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
			}
		}
		
		void ScriptTextBoxTextChanged(object sender, EventArgs e)
		{
			host.UpdateFile(0, scriptTextBox.Text);
		}
		
		void SignatureCompletionToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
				host.Position = scriptTextBox.SelectionStart;
				string source = File.ReadAllText("SignatureCompletion.js");
				context.Run(source);
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
			}
		}
	}
}
