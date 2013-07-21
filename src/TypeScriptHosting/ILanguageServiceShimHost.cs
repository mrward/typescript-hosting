// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;

namespace TypeScriptHosting
{
	public interface ILanguageServiceShimHost : ILogger
	{
		string getCompilationSettings();
		string getScriptFileNames();
		int getScriptVersion(string fileName);
		bool getScriptIsOpen(string fileName);
		IScriptSnapshotShim getScriptSnapshot(string fileName);
		ILanguageServicesDiagnostics getDiagnosticsObject();
	}
}
