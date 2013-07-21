// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;

namespace TypeScriptHosting
{
	public interface IScriptSnapshotShim
	{
		// Get's a portion of the script snapshot specified by [start, end).
		string getText(int start, int end);

		// Get's the length of this script snapshot.
		int getLength();

		// This call returns the JSON encoded array of the type:
		//  number[]
		string getLineStartPositions();

		// Returns a JSON encoded value of the type:
		//  { span: { start: number; length: number }; newLength: number }
		//
		// Or null value if there was no change.
		string getTextChangeRangeSinceVersion(int scriptVersion);
	}
}
