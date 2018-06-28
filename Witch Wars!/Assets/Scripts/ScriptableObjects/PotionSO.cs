/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "New Potion", menuName = "Custom/Potion", order = 1)]
public class PotionSO : ScriptableObject {

	public string potionName;
	[TextArea]
	public string potionDescription;
	public float potionEffectRadius;
	public float potionDamage;
	public enum PotionEffect
	{
		DAMAGE,
		POISON,
		FROST,
		FLAME,
		HEALING
	}
	public PotionEffect potionEffect;
	public float effectTime;

}
