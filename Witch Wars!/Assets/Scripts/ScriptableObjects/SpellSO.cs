/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using Sirenix.OdinInspector;

[System.Serializable]
[CreateAssetMenu(fileName = "New Spell", menuName = "Custom/Spell", order = 2)]
public class SpellSO : ScriptableObject {

	public string spellName;
	[TextArea]
	public string spellDescription;
	public int levelToUnlock;
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
	public SpellEffect spellEffect;
	public float effectValue;
	public GameObject objectToSummon;
}
