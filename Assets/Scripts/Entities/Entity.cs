using UnityEngine;
using UnityEngine.Events;

namespace GameJam
{
	public class Entity : MonoBehaviour
	{
		public UnityEvent Destroyed = new UnityEvent();
		public Transform targetSpawn;
		private bool m_insideTrigger;
		public bool useable = false;

		private void OnTriggerEnter(Collider other)
		{
			if (!useable) return;
			UseUI.Instance.Show();
			m_insideTrigger = true;
		}

		private void OnTriggerExit(Collider other)
		{
			if (!useable) return;
			UseUI.Instance.Hide();
			m_insideTrigger = false;
		}

		private void Update()
		{
			if(m_insideTrigger && Input.GetKeyDown(KeyCode.E))
			{
				Player.Instance.SetLoaction(targetSpawn);
			}
		}


		public virtual void Destroy()
		{
			Destroy(gameObject);
			Destroyed.Invoke();
		}
	}
}
