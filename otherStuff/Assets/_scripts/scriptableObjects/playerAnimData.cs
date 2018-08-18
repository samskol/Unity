using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "soAssets/Player Anim Data")]
public class playerAnimData : ScriptableObject {

	[Serializable]
	public struct AnimInfo
	{
		public string clipName;
		public float posx;
		public float posy;
		public float posz;
	}
	public List<AnimInfo> animClips;

}
