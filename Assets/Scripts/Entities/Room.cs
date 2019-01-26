using System.Collections.Generic;
using UnityEngine;

namespace GameJam
{
	public class Room : MonoBehaviour
	{
		[SerializeField]
		private List<Entity> m_completeEntities = new List<Entity>();

		[SerializeField]
		private List<InventoryItem> m_inventoryItems = new List<InventoryItem>();

		public void CheckComplete()
		{
			if (m_inventoryItems.TrueForAll(x => x.Collected))
			{
				Complete();
			}
		}

		public void Complete()
		{
			m_completeEntities.ForEach(x => x.Destroy());
		}
	}
}
