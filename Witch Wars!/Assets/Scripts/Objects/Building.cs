/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using UnityEngine.Networking;
using Sirenix.OdinInspector;

public class Building : MonoBehaviour {

	#region Variables
	public BuildingSO buildingSO;
	public float health;

	#endregion
	
	#region Methods

	void Start () 
	{
		health = buildingSO.buildingHP;
	}
	
	void Update () 
	{
		
	}
	
	#endregion
}
