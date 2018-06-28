/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using Sirenix.OdinInspector;

[System.Serializable]
[CreateAssetMenu(fileName = "New Spell", menuName = "Custom/Spell", order = 2)]
public class SpellSO : ScriptableObject {

	[Title("Text Attributes")]
	public string spellName;
	[TextArea]
	public string spellDescription;
	[Space(7)]
	public int levelToUnlock;
	[Space(7)]
	[Title("Value Attributes")]
	public float manaCost;
	public float castTime;
	public float damage;
	public enum SpellEffect
	{
		DOT,
		DAMAGE,
		FREEZE,
		DAZE,
		SUMMON
	}
	[Space(7)]
	[Title("Effect Attributes")]
	public SpellEffect spellEffect;
	public float effectValue;
	public GameObject objectToSummon;
	public int amountToSummon;
	[Space(7)]
	[Title("Upgrade Attributes")]
	public int amountToSummonUpgrade;
	public float effectValueUpgrade;

}
