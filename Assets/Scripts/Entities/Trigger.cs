using UnityEngine;
using UnityEngine.Events;

namespace GameJam
{
	public class Trigger : MonoBehaviour
	{
		public UnityEvent Entered = new UnityEvent();
		public UnityEvent Exited = new UnityEvent();

		private void OnTriggerEnter(Collider other)
		{
			Entered.Invoke();			
		}

		private void OnTriggerExit(Collider other)
		{
			Exited.Invoke();	
		}
	}
}
