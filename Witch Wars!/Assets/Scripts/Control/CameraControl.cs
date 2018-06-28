/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using UnityEngine.Networking;
using Sirenix.OdinInspector;

public class CameraControl : NetworkBehaviour {

	#region Variables
	public float speed;
	#endregion
	
	#region Methods

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
		}
	}
	
	#endregion
}
