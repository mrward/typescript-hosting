// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TypeScriptHosting
{
	public class LanguageServiceShimHost : ILanguageServiceShimHost
	{
		List<Script> scripts = new List<Script>();
		
		public LanguageServiceShimHost()
		{
		}
		
		public void AddFile(string fileName, string text)
		{
			scripts.Add(new Script(fileName, text));
		}
		
		public void UpdateFile(int index, string text)
		{
			scripts[index].Update(text);
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
		
		void LogFormat(string format, params object[] args)
		{
			log(String.Format(format, args));
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
		
		public int getScriptCount()
		{
			log("Host.getScriptCount");
			return scripts.Count;
		}
		
		public string getScriptId(int scriptIndex)
		{
			log("Host.getScriptId: " + scriptIndex);
			return scripts[scriptIndex].Id;
		}
		
		public string getScriptSourceText(int scriptIndex, int start, int end)
		{
			LogFormat("Host.getScriptSourceText: index={0}, start={1}, end={2}", scriptIndex, start, end);
			Script script = scripts[scriptIndex];
			return script.Source.Substring(start, end - start);
		}
		
		public int getScriptSourceLength(int scriptIndex)
		{
			log("Host.getScriptId: " + scriptIndex);
			return scripts[scriptIndex].Source.Length;
		}
		
		public bool getScriptIsResident(int scriptIndex)
		{
			log("Host.getScriptIsResident: " + scriptIndex);
			return false;
		}
		
		public int getScriptVersion(int scriptIndex)
		{
			log("Host.getScriptVersion: " + scriptIndex);
			return scripts[scriptIndex].Version;
		}
		
		public string getScriptEditRangeSinceVersion(int scriptIndex, int scriptVersion)
		{
			LogFormat("Host.getScriptId: index={0}, version={1}", scriptIndex, scriptVersion);
			Script script = scripts[scriptIndex];
			if (script.Version == scriptVersion)
				return null;
			
			return "{ \"minChar\": -1, \"limChar\": -1, \"delta\": -1}";
		}
	}
}
