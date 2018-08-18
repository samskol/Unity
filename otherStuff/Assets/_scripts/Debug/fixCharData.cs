using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class fixCharData : MonoBehaviour {
	//public GameObject hi;
	[MenuItem("Debug/fix char Data")]
	public static void fixData()
	{
		if (Selection.activeGameObject != null)
		{
			List<charData.ThrowData> throwData = Selection.activeGameObject.GetComponent<fixChargo>().chargo.throwData;
			float totalChance = 0f;
			for (int i = 0; i < throwData.Count; i++)
			{
				totalChance += throwData[i].chance;
				float totalBPoints = throwData[i].aimVal + throwData[i].semiVal + throwData[i].miss;
				charData.ThrowData temp = new charData.ThrowData(throwData[i].anim, throwData[i].chance, throwData[i].difficulty, (throwData[i].semiVal * 100) / totalBPoints, (throwData[i].aimVal * 100) / totalBPoints, (throwData[i].miss * 100) / totalBPoints);
				Selection.activeGameObject.GetComponent<fixChargo>().chargo.throwData[i] = temp;
				float hi = (throwData[i].semiVal * 100) / totalBPoints + (throwData[i].aimVal * 100) / totalBPoints + (throwData[i].miss * 100) / totalBPoints;
				Debug.Log("i " + i + " total: " + hi);
			}
			float checkChance = 0f;
			for (int i = 0; i < throwData.Count; i++)
			{
				throwData[i] = new charData.ThrowData(throwData[i].anim, (throwData[i].chance * 100) / totalChance, throwData[i].difficulty,throwData[i].semiVal, throwData[i].aimVal, throwData[i].miss);
				checkChance += throwData[i].chance;
			}
			Debug.Log("chanceCheck: " + checkChance);
		}
	}
}
