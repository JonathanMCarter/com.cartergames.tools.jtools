using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class AutoSaveSceneTool : EditorWindow
{

	public int DelaySec;
	public int NextSave;

	public float Timer;

	public double LastUpdate;

	// Booleans for the script
	private bool StartTimer;
	private bool RunScript;

	// Custom Button Colours
	private Color32 EnableButtonColour = new Color32(127, 230, 187, 255);
	private Color32 DisableButtonColour = new Color32(255, 177, 177, 255);

	// Shows the tool in the window menu and gives it its shortcut
	[MenuItem("Window/AutoSaveScene #A")]
	public static void ShowWindow()
	{
		GetWindow<AutoSaveSceneTool>("Auto Save Scene");
	}



	private void OnGUI()
	{
		Header();

		EditorGUILayout.BeginHorizontal();
		EditorGUILayout.LabelField("Enter Delay In Seconds: ", EditorStyles.boldLabel, GUILayout.MaxWidth(165));
		DelaySec = EditorGUILayout.IntField(DelaySec, GUILayout.MaxWidth(65));
		EditorGUILayout.EndHorizontal();

		GUILayout.Space(15);

		BeginCenter();
		EditorGUILayout.LabelField("Delay Set To: " + DelaySec / 60 + " Mins & " + DelaySec % 60  + " Seconds");
		EndCenter();

		GUILayout.Space(10);


		BeginCenter();

		if (!RunScript)
		{
			GUI.color = EnableButtonColour;

			if (GUILayout.Button("Enable Autosave", GUILayout.MaxWidth(140)))
			{
				RunScript = true;
			}
		}
		else
		{
			GUI.color = DisableButtonColour;

			if (GUILayout.Button("Disable Autosave", GUILayout.MaxWidth(140)))
			{
				StartTimer = false;
				DelaySec = 0;
				Timer = 0;
				LastUpdate = 0;
				RunScript = false;
			}
		}

		EndCenter();


		GUI.color = Color.white;

		if (RunScript)
		{

			BeginCenter();

			//Timer = DelaySec;
			StartTimer = true;

			if (Timer >= 60)
			{
				EditorGUILayout.LabelField("Time Until Next Save: " + Mathf.FloorToInt(Timer / 60) + " Mins & " + Mathf.FloorToInt(Timer % 60) + " Seconds");
			}
			else
			{
				EditorGUILayout.LabelField("Time Until Next Save: " + Mathf.FloorToInt(Timer % 60) + " Seconds");
			}

			EndCenter();
		}

		if (StartTimer)
		{
			Timer -= EditorDeltaTime();
		}

		if (Timer < 0)
		{
			StartTimer = false;
			LastUpdate = 0;
			SaveScene();
			Timer = DelaySec;
			StartTimer = true;
		}

		Repaint();
	}


	private void Header()
	{
		GUILayout.Space(10f);
		EditorGUILayout.HelpBox(
			"Autosaves the open scenes on the inputted time delay, To use the tool just enter the amount of time " +
			"you want between each save and then press enable to start the timer. To stop the timer just press the disable buton when the timer " +
			"is enabled.", MessageType.None);
		GUILayout.Space(10f);
	}

	private void SaveScene()
	{
		// Save All Open Scenes
		EditorSceneManager.SaveOpenScenes();
	}


	private float EditorDeltaTime()
	{
		double EditorTime;

		if (LastUpdate == 0)
		{
			LastUpdate = EditorApplication.timeSinceStartup;
		}

		EditorTime = EditorApplication.timeSinceStartup - LastUpdate;
		LastUpdate = EditorApplication.timeSinceStartup;

		return (float)EditorTime;
	}


	private void BeginCenter()
	{
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
	}

	private void EndCenter()
	{
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}
}
