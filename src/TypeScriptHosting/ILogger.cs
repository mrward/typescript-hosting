// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;

namespace TypeScriptHosting
{
	public interface ILogger
	{
		bool information();
		bool debug();
		bool warning();
		bool error();
		bool fatal();
		void log(string s);
	}
}
