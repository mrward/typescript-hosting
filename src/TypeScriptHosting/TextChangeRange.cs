// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;

namespace TypeScriptHosting
{
	// "{ \"span\": { \"start\": 0, \"length\": {0}) }, \"newLength\": {1} }",
	public class TextChangeRange
	{
		public TextChangeRange(int start, int length, int newLength)
			: this(new TextSpan(start, length), newLength)
		{
		}
		
		public TextChangeRange(TextSpan span, int newLength)
		{
			this.span = span;
			this.newLength = newLength;
		}
		
		public TextSpan span { get; set; }
		public int newLength { get; set; }
	}
}
