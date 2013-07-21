// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TypeScriptHosting
{
	public class LanguageServiceShimHost : ILanguageServiceShimHost
	{
		Dictionary<string, Script> scripts = new Dictionary<string, Script>();
		
		public LanguageServiceShimHost()
		{
		}
		
		public void AddFile(string fileName, string text)
		{
			scripts.Add(fileName, new Script(fileName, text));
		}
		
		public void UpdateFile(string fileName, string text)
		{
			scripts[fileName].Update(text);
		}
		
		public int Position { get; set; }
		public string FileName { get; set; }
		
		public int getPosition()
		{
			return Position;
		}
		
		public bool information()
		{
			return true;
		}
		
		public bool debug()
		{
			return true;
		}
		
		public bool warning()
		{
			return true;
		}
		
		public bool error()
		{
			return true;
		}
		
		public bool fatal()
		{
			return true;
		}
		
		public void log(string s)
		{
			Console.WriteLine(s);
		}
		
		public void foo(object o)
		{
			Console.WriteLine(o);
		}
		
		public void updateCompletionInfoAtCurrentPosition(string completionInfo)
		{
			log(completionInfo);
			CompletionResult result = JsonConvert.DeserializeObject<CompletionResult>(completionInfo);
		}
		
		public string getCompilationSettings()
		{
			log("Host.getCompilationSettings");
			return null;
		}
		
		public IScriptSnapshotShim getScriptSnapshot(string fileName)
		{
			log("Host.getScriptSnapshot: " + fileName);
			Script script = scripts[fileName];
			return new ScriptSnapshotShim(script);
		}
		
		public bool getScriptIsOpen(string fileName)
		{
			log("Host.getScriptIsOpen: " + fileName);
			if (fileName == "lib.d.ts") {
				return false;
			}
			return true;
		}
		
		public int getScriptVersion(string fileName)
		{
			log("Host.getScriptVersion: " + fileName);
			return scripts[fileName].Version;
		}
		
		public ILanguageServicesDiagnostics getDiagnosticsObject()
		{
			log("Host.getDiagnosticsObject");
			return new LanguageServicesDiagnostics();
		}
		
		public string getScriptFileNames()
		{
			log("Host.getScriptFileNames");
			
			string json = JsonConvert.SerializeObject(scripts.Keys.ToArray());
			
			log("Host.getScriptFileNames: " + json);
			
			return json;
		}
	}
}
