using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
	[SerializeField] float speeds = 10f;
	// Update is called once per frame
	void Update () 
	{
		MeshRenderer MR = GetComponent<MeshRenderer> ();
		Material mate = MR.material;
		Vector2 offset = mate.mainTextureOffset;
		if (offset.y >= 10) 
		{
			offset.y = 0;
		}
		offset.y += Time.deltaTime / speeds;
		mate.mainTextureOffset = offset;

		
	}
}
