// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;

namespace TypeScriptHosting
{
	public interface ILanguageServiceShimHost : ILogger
	{
		string getCompilationSettings();
		int getScriptCount();
		string getScriptId(int scriptIndex);
		string getScriptSourceText(int scriptIndex, int start, int end);
		int getScriptSourceLength(int scriptIndex);
		bool getScriptIsResident(int scriptIndex);
		int getScriptVersion(int scriptIndex);
		string getScriptEditRangeSinceVersion(int scriptIndex, int scriptVersion);
	}
}
