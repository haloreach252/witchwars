/*
* Copyright (c) Engineer Industries
* https://www.youtube.com/channel/UC-v_UB0BIwIoKlcq2ZoRmFg
*/

using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "New Building", menuName = "Custom/Building", order = 3)]
public class BuildingSO : ScriptableObject{

	public string buildingName;
	[TextArea]
	public string buildingDescription;
	public float goldCost;
	public float buildTime;
	public float buildingHP;
	public float damage;
	public enum BuildingType
	{
		SUPPORT,
		DEFENSE,
		OFFENSE
	}
	public BuildingType buildingType;

}
