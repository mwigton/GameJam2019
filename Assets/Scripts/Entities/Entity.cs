using UnityEngine;
using UnityEngine.Events;

namespace GameJam
{
	public class Entity : MonoBehaviour
	{
		public UnityEvent Destroyed = new UnityEvent(); 

		public virtual void Destroy()
		{
			Destroy(gameObject);
			Destroyed.Invoke();
		}
	}
}
