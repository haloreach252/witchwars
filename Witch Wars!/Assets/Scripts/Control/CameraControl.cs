/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using UnityEngine.Networking;
using Sirenix.OdinInspector;

public class CameraControl : NetworkBehaviour {

	#region Variables
	public float xSpeed;
	public float zSpeed;
	#endregion

	#region Methods

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (!isLocalPlayer)
		{
			return;
		}

		//Movement
		float deltaX = Input.GetAxis("Horizontal") * xSpeed;
		float deltaZ = Input.GetAxis("Vertical") * zSpeed;

		Vector3 trans = new Vector3(deltaX, 0f, deltaZ);
		Camera.main.transform.Translate(trans * Time.deltaTime, Space.World);
	}
	
	#endregion
}
