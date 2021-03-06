﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ICSharpCode.TypeScriptBinding.Hosting;

namespace TypeScriptHosting
{
	public class LanguageServiceShimHost : ILanguageServiceShimHost, ICancellationToken
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
		
		public void trace(string s)
		{
			log(s);
		}
		
		public void error(string s)
		{
			log(s);
		}
		
		public void updateCompletionInfoAtCurrentPosition(string completionInfo)
		{
			log(completionInfo);
			CompletionResult result = JsonConvert.DeserializeObject<CompletionResult>(completionInfo);
		}
		
		public string getCompilationSettings()
		{
			log("Host.getCompilationSettings");
			return JsonConvert.SerializeObject(new CompilerOptions() { target = ScriptTarget.ES5 });
		}
		
		public IScriptSnapshotShim getScriptSnapshot(string fileName)
		{
			log("Host.getScriptSnapshot: " + fileName);
			Script script = scripts[fileName];
			return new ScriptSnapshotShim(this, script);
		}
		
		public string getScriptVersion(string fileName)
		{
			log("Host.getScriptVersion: " + fileName);
			return scripts[fileName].Version.ToString();
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
		
		public string resolveRelativePath(string path, string directory)
		{
			log("Host.resolveRelativePath: " + path + ", " + directory);
			
			if (Path.IsPathRooted(path) || String.IsNullOrEmpty(directory)) {
				return path;
			} else {
				return Path.Combine(directory, path);
			}
		}
		
		public bool fileExists(string path)
		{
			log("Host.fileExists: " + path);
			return File.Exists(path);
		}
		
		public bool directoryExists(string path)
		{
			log("Host.directoryExists: " + path);
			return Directory.Exists(path);
		}
		
		public string getParentDirectory(string path)
		{
			log("Host.getParentDirectory: " + path);
			throw new NotImplementedException();
		}
		
		public string getLocalizedDiagnosticMessages()
		{
			log("Host.getLocalizedDiagnosticMessages");
			return null;
		}
		
		public string ResolvePath(string path)
		{
			log("ResolvePath: '" + path + "'");
			return path;
		}
		
		public void updateCompilerResult(string compilerResult)
		{
			log(compilerResult);
			CompilerResult result = JsonConvert.DeserializeObject<CompilerResult>(compilerResult);
		}

		public ICancellationToken getCancellationToken()
		{
			return this;
		}

		public bool isCancellationRequested()
		{
			return false;
		}

		public string getCurrentDirectory()
		{
			return String.Empty;
		}

		public string getDefaultLibFilename(string s)
		{
			return String.Empty;
		}
		
		public string getNewLine()
		{
			return Environment.NewLine;
		}
		
		int projectVersion;
		
		public string getProjectVersion()
		{
			projectVersion++;
			return projectVersion.ToString();
		}
		
		public bool useCaseSensitiveFileNames()
		{
			return false;
		}
	}
}
