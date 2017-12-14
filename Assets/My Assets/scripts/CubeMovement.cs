using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
	void FixedUpdate()
	{
		if(Input.GetMouseButton(0))
		{
			this.transform.position = new Vector3(this.transform.position.x + 0.1f, 2, this.transform.position.z);
		}
		else if(Input.GetMouseButton(1))
		{
			this.transform.position = new Vector3(this.transform.position.x + 0.1f, 0, this.transform.position.z);
		}
		else
		{
			this.transform.position = new Vector3(this.transform.position.x + 0.1f, 1, this.transform.position.z);
		}
	}
}