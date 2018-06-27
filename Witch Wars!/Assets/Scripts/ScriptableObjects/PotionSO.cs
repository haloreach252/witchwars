/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "New Potion", menuName = "Custom/Items/Potion", order = 1)]
public class PotionSO : ScriptableObject {

	public string potionName;
	[TextArea]
	public string potionDescription;
	public float potionRadius;
	public float potionDamage;
	public enum PotionEffect
	{
		DAMAGE,
		POISON,
		FREEZE,
		FIRE,
		HEALING
	}
	public PotionEffect potionEffect;

}
