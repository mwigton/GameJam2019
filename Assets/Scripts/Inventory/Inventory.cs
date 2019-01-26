using System.Collections.Generic;

namespace GameJam
{
	public static class Inventory
	{
		private static List<string> m_items = new List<string>();

		public static void Add(string item)
		{
			m_items.Add(item);
		}

		public static bool HasItem(string item)
		{
			return m_items.Contains(item);
		}
	}
}
