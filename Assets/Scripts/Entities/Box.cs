using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameJam
{
	public class Box : Entity
	{
		public override void Destroy()
		{
			//GetComponent<SkinnedMeshRenderer>()
			base.Destroy();
		}
	}
}
