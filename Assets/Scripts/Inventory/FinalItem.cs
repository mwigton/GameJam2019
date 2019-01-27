using UnityEngine;
using System.Collections.Generic;

namespace GameJam
{
	public class FinalItem : InventoryItem
	{
		[SerializeField]
		private Transform m_spawn;

		[SerializeField]
		private GameObject m_finalUI;

		[SerializeField]
		private List<GameObject> m_boxes;

		[SerializeField]
		private List<GameObject> m_enable;

		[SerializeField]
		private Transform m_cameraPivot;

		protected override void OnTrigger()
		{
			Player.Instance.SetLoaction(m_spawn);
			Player.Instance.SetScale(1);
			m_finalUI.SetActive(true);
			m_boxes.ForEach(x => x.SetActive(false));
			m_enable.ForEach(x => x.SetActive(true));
			m_cameraPivot.Translate(Vector3.up * 2);
		}
	}
}
