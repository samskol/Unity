using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CreateAssetMenu(menuName ="soAssets/Scene Level")]
public class levelSettings : ScriptableObject {

	[Serializable]
	public enum GameMode
	{
		s_OneVOne,
		s_OnevTwo,
		s_TwovTwo,
		o_OnevOne,
		o_OnevTwo,
		o_TwovTwo,
		o_TwovOne
	}
	[Serializable]
	public enum AnimMode
	{
		normal,
		spastastic
	}
	[SerializeField]
	public charData u1;
	[SerializeField]
	public charData c1;
	[SerializeField]
	public charData c2;
	[SerializeField]
	public charData u2;
	[SerializeField]
	public GameObject field;
	[SerializeField]
	public GameObject env;
	[SerializeField]
	public int footballs =10;
	[SerializeField]
	public float fieldLength;
	[SerializeField]
	public GameMode gameMode;

	[Tooltip("0 is perfect AI, 100 would miss all the time")]
	[Range(0,1000), SerializeField]
	public int aiOne_difficulty=10;
	[Tooltip("0 is perfect AI, 100 would miss all the time")]
	[Range(0, 1000), SerializeField]
	public int aiTwo_difficulty=10;

	[SerializeField]
	public AnimMode animMode;
	[SerializeField]
	public float spastasticDistance;
	
	[SerializeField]
	public float travelTime;

	[SerializeField]
	public float userTravelTime;
}
