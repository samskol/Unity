using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="soAssets/Enemy Data")]
public class enemyData : ScriptableObject {

	public string name;
	public float moveStep;
	public int health;
	public Color color;
}
