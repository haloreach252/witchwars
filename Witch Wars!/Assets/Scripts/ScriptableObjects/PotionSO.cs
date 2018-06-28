/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using Sirenix.OdinInspector;

[System.Serializable]
[CreateAssetMenu(fileName = "New Potion", menuName = "Custom/Potion", order = 1)]
public class PotionSO : ScriptableObject {

	[Title("Text Attributes")]
	public string potionName;
	[TextArea]
	public string potionDescription;
	[Space(7)]
	[Title("Time and radius Attributes")]
	public float brewTime;
	public float potionEffectRadius;
	public enum PotionEffect
	{
		DAMAGE,
		POISON,
		FROST,
		FLAME,
		HEALING
	}
	[Space(7)]
	[Title("Effect Attributes")]
	public PotionEffect potionEffect;
	public float effectTime;
	public float effectValue;
	[Space(7)]
	[Title("Upgrade Attributes")]
	public float effectTimeUpgrade;
	public float effectValueUpgrade;

}
