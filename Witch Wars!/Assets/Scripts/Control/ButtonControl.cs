/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using Sirenix.OdinInspector;

public class ButtonControl : MonoBehaviour {

	#region Variables
	
	#endregion
	
	#region Methods

	public void EnableGO(GameObject goToEnable)
	{
		goToEnable.SetActive(true);
	}

	public void DisableGO(GameObject goToDisable)
	{
		goToDisable.SetActive(false);
	}

	#endregion
}
