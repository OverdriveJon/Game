using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
	public Transform target;

	public float offset = 200.0f;

	private void LateUpdate()
	{ 
		transform.position = new Vector3(target.position.x+offset, target.position.y+offset, target.position.z+offset);
		transform.LookAt(target);
	}
}
