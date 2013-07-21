// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using System.Linq;

namespace TypeScriptHosting
{
	public class Script
	{
		string fileName;
		List<int> lineStartPositions = new List<int>();
		List<int> lengths = new List<int>();
		
		public Script(string fileName, string source)
		{
			this.fileName = fileName;
			this.Source = source;
			this.Version = 1;
			lengths.Add(source.Length);
		}
		
		public void Update(string source)
		{
			this.Source = source;
			lengths.Add(source.Length);
			Version++;
		}
		
		public string Id {
			get { return fileName; }
		}
		
		public string Source { get; private set; }
		public int Version { get; private set; }
		
		public int[] GetLineStartPositions()
		{
			if (lineStartPositions.Count == 0) {
				string[] lines = Source.Split('\r');
				lineStartPositions.Add(0);
				int position = 0;
				for (int i = 0; i < lines.Length; ++i) {
					position += lines[i].Length + 2;
					lineStartPositions.Add(position);
				}
			}
			
			return lineStartPositions.ToArray();
		}
		
		public TextChangeRange GetTextChangeRangeSinceVersion(int scriptVersion)
		{
			return new TextChangeRange(0, lengths[scriptVersion - 1], Source.Length);
		}
	}
}
