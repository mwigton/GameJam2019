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
			Debug.Log("Checking room complete: " + gameObject.name, this);
			if (m_inventoryItems.TrueForAll(x => x.Collected))
			{
				Complete();
			}
		}

		public void Complete()
		{
			Debug.Log("Room complete: " + gameObject.name, this);
			m_completeEntities.ForEach(x => x.Destroy());
			m_completeEntities.Clear();
		}
	}
}
