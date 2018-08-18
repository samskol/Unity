using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using System.IO;

public class getBonePosition : MonoBehaviour {

	public playerAnimData animSOData;

	private int updateFrame;
	private GameObject ballPos;

	[Serializable]
	public struct AnimInfo {
		public AnimationClip clip;
		public int releaseKey;
	}
	public List<AnimInfo> animClips;

	private string pathSO;

	//should add function to clear existing so data
	void Start () {
		ballPos = GameObject.FindGameObjectWithTag("positionUtility");
		pathSO = Application.streamingAssetsPath + "/_SoAssets/animData/" + animSOData.name;

		EditorUtility.SetDirty(animSOData);
		sampleAnims();
	}

	public void sampleAnims()
	{
		for(updateFrame=0;  updateFrame < animClips.Count; updateFrame++)
		{
			float animFrameRate = animClips[updateFrame].clip.frameRate;
			float sFrame = animClips[updateFrame].releaseKey;
			float time = (float)((1.0f / animFrameRate) * sFrame);
			animClips[updateFrame].clip.SampleAnimation(this.gameObject, time);
			Vector3 pos = ballPos.transform.position;
			Debug.Log("pos: " + pos.x + " " + pos.y + " " + pos.z);
			playerAnimData.AnimInfo temp = new playerAnimData.AnimInfo();
			temp.clipName = animClips[updateFrame].clip.name;
			temp.posx = pos.x;
			temp.posy = pos.y;
			temp.posz = pos.z;
			animSOData.animClips.Add(temp);
		}
		
	}
}
