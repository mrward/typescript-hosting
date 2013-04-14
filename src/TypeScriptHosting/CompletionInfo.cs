// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;

namespace TypeScriptHosting
{
	public class CompletionInfo
	{
		public CompletionInfo()
		{
			entries = new CompletionEntry[0];
		}
		
		public bool maybeInaccurate { get; set; }
		public bool isMemberCompletion { get; set; }
		public CompletionEntry[] entries;
	}
}
