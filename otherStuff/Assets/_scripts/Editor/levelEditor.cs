using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(levelSettings))]
public class sceneLevelEditor : Editor {

	public override void OnInspectorGUI()
	{
		
		var sceneLevel = target as levelSettings;
		EditorUtility.SetDirty(target);
		sceneLevel.env = (GameObject)EditorGUILayout.ObjectField("env:",sceneLevel.env, typeof(GameObject), true);
		sceneLevel.footballs = EditorGUILayout.IntSlider("footballs", sceneLevel.footballs, 0, 10);

		sceneLevel.gameMode = (levelSettings.GameMode) EditorGUILayout.EnumPopup("GameMode", sceneLevel.gameMode);

		switch (sceneLevel.gameMode)
		{
			case levelSettings.GameMode.s_OneVOne:
				{
					//c1 c2 c3 c4 character anim data and player data/difficulty so and such
					sceneLevel.u1 = (charData)EditorGUILayout.ObjectField("u1", sceneLevel.u1, typeof(charData), true);
					sceneLevel.c1 = (charData)EditorGUILayout.ObjectField("c1", sceneLevel.c1, typeof(charData), true);
					sceneLevel.aiOne_difficulty = EditorGUILayout.IntSlider("aiOne Difficulty", sceneLevel.aiOne_difficulty, 0,1000);
					break;
				}
			case levelSettings.GameMode.s_OnevTwo:
				{
					sceneLevel.u1 = (charData)EditorGUILayout.ObjectField("u1", sceneLevel.u1, typeof(charData), true);
					sceneLevel.c1 = (charData)EditorGUILayout.ObjectField("c1", sceneLevel.c1, typeof(charData), true);
					sceneLevel.c2 = (charData)EditorGUILayout.ObjectField("c2", sceneLevel.c2, typeof(charData), true);
					sceneLevel.aiOne_difficulty = EditorGUILayout.IntSlider("ai 1 Difficulty", sceneLevel.aiOne_difficulty, 0, 1000);
					sceneLevel.aiTwo_difficulty = EditorGUILayout.IntSlider("ai 2 Difficulty", sceneLevel.aiTwo_difficulty, 0, 1000);
					break;
				}
			case levelSettings.GameMode.s_TwovTwo:
				{
					sceneLevel.u1 = (charData)EditorGUILayout.ObjectField("u1", sceneLevel.u1, typeof(charData), true);
					sceneLevel.c1 = (charData)EditorGUILayout.ObjectField("c1", sceneLevel.c1, typeof(charData), true);
					sceneLevel.c2 = (charData)EditorGUILayout.ObjectField("c2", sceneLevel.c2, typeof(charData), true);//c3?
					sceneLevel.u2 = (charData)EditorGUILayout.ObjectField("u2", sceneLevel.u2, typeof(charData), true);
					sceneLevel.aiOne_difficulty = EditorGUILayout.IntSlider("ai 1 Difficulty", sceneLevel.aiOne_difficulty, 0, 1000);
					sceneLevel.aiTwo_difficulty = EditorGUILayout.IntSlider("ai 2 Difficulty", sceneLevel.aiTwo_difficulty, 0, 1000);
					break;
				}
			case levelSettings.GameMode.o_OnevOne:
				{
					break;
				}
			case levelSettings.GameMode.o_OnevTwo:
				{
					break;
				}
			case levelSettings.GameMode.o_TwovOne:
				{
					break;
				}
			case levelSettings.GameMode.o_TwovTwo:
				{
					break;
				}

		}
		sceneLevel.animMode = (levelSettings.AnimMode)EditorGUILayout.EnumPopup("animMode", sceneLevel.animMode);
		switch (sceneLevel.animMode)
		{
			case levelSettings.AnimMode.spastastic:
				sceneLevel.spastasticDistance = EditorGUILayout.FloatField("spasmode distance between players: ", sceneLevel.spastasticDistance);
				sceneLevel.travelTime = EditorGUILayout.FloatField("travel time: ", sceneLevel.travelTime);
				sceneLevel.userTravelTime = EditorGUILayout.FloatField("user travel time: ", sceneLevel.userTravelTime);
				break;
			case levelSettings.AnimMode.normal:
				sceneLevel.field = (GameObject)EditorGUILayout.ObjectField("field", sceneLevel.field, typeof(GameObject), true);
				sceneLevel.fieldLength = EditorGUILayout.FloatField("fieldLength", sceneLevel.fieldLength);
				if (sceneLevel.fieldLength < 1.0f)
				{
					sceneLevel.fieldLength = 1.0f;
				}
				if (sceneLevel.fieldLength > 3.0f)
				{
					sceneLevel.fieldLength = 3.0f;
				}
				break;
		}

	}
}
