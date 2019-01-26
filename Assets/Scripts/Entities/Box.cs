using System.Collections;
using UnityEngine;

namespace GameJam
{
	public class Box : Entity
	{
		[SerializeField]
		private float m_speed = 1;

		private SkinnedMeshRenderer m_skinnedMeshRenderer;

		private void Start()
		{
			m_skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
		}

		public override void Destroy()
		{
			StartCoroutine(DestroyEnum());
		}

		private IEnumerator DestroyEnum()
		{
			float weight = 0;
			while(weight < 100)
			{
				m_skinnedMeshRenderer.SetBlendShapeWeight(0, weight);
				weight += Time.deltaTime * m_speed;
				yield return null;
			}

			yield return new WaitForSeconds(.5f);
			base.Destroy();
		}
	}
}
