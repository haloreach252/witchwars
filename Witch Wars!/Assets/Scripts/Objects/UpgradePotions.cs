/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using UnityEngine.Networking;
using Sirenix.OdinInspector;

public class UpgradePotions : NetworkBehaviour {

	#region Variables
	public PotionSO healthPotion;
	public PotionSO frostPotion;
	public PotionSO flamePotion;
	public PotionSO poisonPotion;
	public PotionSO damagePotion;
	#endregion

	#region Methods

	public void Upgrade()
	{
		healthPotion.effectValue += 20;
		frostPotion.effectTime += 1;
		flamePotion.effectTime += 1;
		flamePotion.effectValue += 4;
		poisonPotion.effectTime += 2;
		poisonPotion.effectValue += 3;
		damagePotion.effectValue += 10;
	}

	#endregion
}
