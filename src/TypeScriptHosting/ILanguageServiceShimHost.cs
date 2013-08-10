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
		ByteOrderMark getScriptByteOrderMark(string fileName);
		IScriptSnapshotShim getScriptSnapshot(string fileName);
		string resolveRelativePath(string path, string directory);
		bool fileExists(string path);
		bool directoryExists(string path);
		string getParentDirectory(string path);
		ILanguageServicesDiagnostics getDiagnosticsObject();
		string getLocalizedDiagnosticMessages();
	}
}
