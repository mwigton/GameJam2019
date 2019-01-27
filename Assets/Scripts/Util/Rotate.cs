using UnityEngine;

namespace GameJam
{
	public class Rotate : MonoBehaviour
	{
		public Vector3 speed;

		private void Update()
		{
			transform.Rotate(speed * Time.deltaTime);
		}
	}
}
