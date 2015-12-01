/*
Copyright (c) 2015 Kevin O'Brien



Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:



The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.



THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
namespace SE
{
	/// <summary>
	/// Utility methods for various common operations in Space Engineers.
	/// </summary>
	/// <seealso href="http://www.spaceengineersgame.com/"/>
	/// <seealso href="http://www.spaceengineerswiki.com/Programming"/>
	class Utility
	{
		/// <summary>
		/// Returns list of blocks of a group.
		/// </summary>
		/// <param name="groupName">Name of block group.</param>
		/// <returns>List of blocks of <paramref name="groupName"/> or <see langword="null"/> if group not found.</returns>
		List<IMyTerminalBlock> GetBlockGroup(string groupName)
		{
			var groups = new List<IMyBlockGroup>();
			GridTerminalSystem.GetBlockGroups(groups);
			for(int i = 0; i < groups.Count; i++)
			{
				if(groups[i].Name.Equals(groupName))
				{
					return groups[i].Blocks;
				}
			}
			return null;
		}
	}
}
