// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using ICSharpCode.TypeScriptBinding.Hosting;

namespace TypeScriptHosting
{
	public class LanguageServicesDiagnostics : ILanguageServicesDiagnostics
	{
		public void log(string content)
		{
			Console.WriteLine("Diagnostics: {0}", content);
		}
	}
}
