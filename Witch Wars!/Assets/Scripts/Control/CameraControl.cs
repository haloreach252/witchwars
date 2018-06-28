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

	public float minFov;
	public float maxFov;
	public float sensitivity;
	#endregion

	#region Methods

	void Start () 
	{
		
	}
	
	void Update () 
	{
		//Movement
		float deltaX = Input.GetAxis("Horizontal") * xSpeed;
		float deltaZ = Input.GetAxis("Vertical") * zSpeed;

		Vector3 trans = new Vector3(deltaX, 0f, deltaZ);
		transform.Translate(trans * Time.deltaTime, Space.World);

		//Zooming
		float fov = Camera.main.fieldOfView;
		fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
		fov = Mathf.Clamp(fov, minFov, maxFov);
		Camera.main.fieldOfView = fov;
	}
	
	#endregion
}
