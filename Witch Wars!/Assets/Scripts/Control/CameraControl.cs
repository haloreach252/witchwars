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

	public float rotateSpeed;

	public GameObject camHold;
	public new GameObject camera;
	#endregion

	#region Methods

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (!isLocalPlayer)
		{
			camera.SetActive(false);
			return;
		}

		//Movement
		float deltaX = Input.GetAxis("Horizontal") * xSpeed;
		float deltaZ = Input.GetAxis("Vertical") * zSpeed;

		float rotY = Input.GetAxis("Rotate") * rotateSpeed;

		Vector3 rot = new Vector3(0, -rotY, 0);
		Vector3 trans = new Vector3(deltaX, 0f, deltaZ);
		camHold.transform.Translate(trans * Time.deltaTime);

		camHold.transform.Rotate(rot * Time.deltaTime);

		//camera.transform.Translate(trans * Time.deltaTime);
	}
	
	#endregion
}
