using UnityEngine;

namespace GameJam
{
	public class Entity : MonoBehaviour
	{
		public virtual void Destroy()
		{
			Destroy(gameObject);
		}
	}
}
