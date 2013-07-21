// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using Newtonsoft.Json;

namespace TypeScriptHosting
{
	public class ScriptSnapshotShim : IScriptSnapshotShim
	{
		Script script;
		
		public ScriptSnapshotShim(Script script)
		{
			this.script = script;
		}
		
		public string getText(int start, int end)
		{
			Log("ScriptSnapshotShim.getText: start={0}, end={1}", start, end);
			return script.Source.Substring(start, end - start);
		}
		
		public int getLength()
		{
			Log("ScriptSnapshotShim.getLength");
			return script.Source.Length;
		}
		
		public string getLineStartPositions()
		{
			Log("ScriptSnapshotShim.getLineStartPositions");
			
			int[] positions = script.GetLineStartPositions();
			string json = JsonConvert.SerializeObject(positions);
			
			Log("ScriptSnapshotShim.getLineStartPositions: {0}", json);
			
			return json;
		}
		
		public string getTextChangeRangeSinceVersion(int scriptVersion)
		{
			Log("ScriptSnapshotShim.getTextChangeRangeSinceVersion: version={0}", scriptVersion);
			if (script.Version == scriptVersion)
				return null;
		
			TextChangeRange textChangeRange = script.GetTextChangeRangeSinceVersion(scriptVersion);
			string json = JsonConvert.SerializeObject(textChangeRange);
			Log("ScriptSnapshotShim.getTextChangeRangeSinceVersion: json: {0}", json);
			return json;
		}
		
		void Log(string format, params object[] args)
		{
			Console.WriteLine(format, args);
		}
	}
}
