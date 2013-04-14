// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;

namespace TypeScriptHosting
{
	public class Script
	{
		string fileName;
		
		public Script(string fileName, string source)
		{
			this.fileName = fileName;
			this.Source = source;
			this.Version = 1;
		}
		
		public void Update(string source)
		{
			this.Source = source;
			Version++;
		}
		
		public string Id {
			get { return fileName; }
		}
		
		public string Source { get; private set; }
		public int Version { get; private set; }
	}
}
