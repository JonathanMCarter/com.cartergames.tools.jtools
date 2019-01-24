using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class JTools : EditorWindow
{

	private string RenameString;
	private bool ShowRenameGameObject;
	private string FindString;
	private string ReplaceString;
	private bool ShowFindReplace;

	//private MonoScript Script;
	//private bool ShowAddScript;

	private bool ShowInitPrefab;

	[SerializeField]
	private GameObject[] Prefabs = new GameObject[10];

	[MenuItem("Window/J-Tools _j")]
	public static void ShowWindow()
	{
		GetWindow<JTools>("J-Tools");
	}



	private void OnGUI()
	{
		Header();

		RenameGameObject();

		FindAndReplaceNames();

		//AddScripts();

		InitPrefabs();
	}



	private void Header()
	{
		GUILayout.Space(10f);
		GUILayout.Label("J-Tools", EditorStyles.boldLabel);
		GUILayout.Label("A random selection of tools that may or may not be useful.");
	}


	//public void AddScripts()
	//{
	//	GUILayout.Space(10f);
	//	GUILayout.Label("Add Script To Object", EditorStyles.boldLabel);

	//	ShowAddScript = EditorGUILayout.Foldout(ShowAddScript, "Options");

	//	if (ShowAddScript)
	//	{
	//		EditorGUILayout.HelpBox("Select the script you wish to add to the objects. Then select the gameobject(s) you wish to add that script to", MessageType.None);

	//		GUILayout.BeginHorizontal();
	//		EditorGUILayout.PrefixLabel("Script To Attach: ");
	//		Script = EditorGUILayout.ObjectField(Script, typeof(MonoScript), false) as MonoScript;
	//		GUILayout.EndHorizontal();

	//		GUILayout.BeginHorizontal();
	//		GUILayout.FlexibleSpace();
	//		if (GUILayout.Button("Attach Script", GUILayout.MaxWidth(100)))
	//		{
	//			if (Script != this)
	//			{
	//				foreach (GameObject Obj in Selection.gameObjects)
	//				{
	//					if (Obj.GetComponent<MonoScript>().name != Script.name)
	//					{

	//					}
	//				}
	//			}
	//		}
	//		GUILayout.EndHorizontal();
	//	}
	//}

	


	public void InitPrefabs()
	{
		GUILayout.Space(10f);
		GUILayout.Label("Spawn Prefabs Into Scene", EditorStyles.boldLabel);

		EditorGUILayout.HelpBox("This tool currently doesn't work!", MessageType.Error);

		ShowInitPrefab = EditorGUILayout.Foldout(ShowInitPrefab, "Options");

		if (ShowInitPrefab)
		{
			EditorGUILayout.HelpBox("Spawns all objects in the array.", MessageType.Info);

			// Bit of code that makes the array visable
			ScriptableObject Target = this;
			SerializedObject SO = new SerializedObject(Target);
			SerializedProperty TestPrefabs = SO.FindProperty("Prefabs");

			EditorGUILayout.PropertyField(TestPrefabs, true);
			SO.ApplyModifiedProperties();
			// end of bit of code that does the thing stated above

			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();

			if (GUILayout.Button("Spawn Prefabs", GUILayout.MaxWidth(100)))
			{
				int Number = 0;

				foreach (GameObject Obj in FindObjectsOfType<GameObject>())
				{
					for (int i = 0; i < Prefabs.Length; i++)
					{
						if (Obj.gameObject == Prefabs[i].gameObject)
						{
							//return;
						}
						else if (Number == FindObjectsOfType<GameObject>().Length)
						{
							Debug.Log("Make OBJ");
						}
						else
						{
							Number++;
						}
					}
				}

				Debug.Log(Number);
				Debug.Log(FindObjectsOfType<GameObject>().Length);
			}

			GUILayout.EndHorizontal();
		}
	}





	public void RenameGameObject()
	{
		GUILayout.Space(10f);
		GUILayout.Label("Rename GameObject(s)", EditorStyles.boldLabel);

		ShowRenameGameObject = EditorGUILayout.Foldout(ShowRenameGameObject, "Options");

		if (ShowRenameGameObject)
		{
			EditorGUILayout.HelpBox("Enter the string value & press the button to change the selected gameobject(s) name(s).", MessageType.Info);

			RenameString = EditorGUILayout.TextField("Name String Value:", RenameString);

			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();

			if (GUILayout.Button("Change Name", GUILayout.MaxWidth(100))) 
			{
				RenameObjectFunction();
			}

			GUILayout.EndHorizontal();
		}
	}


	private void RenameObjectFunction()
	{
		foreach (GameObject Obj in Selection.gameObjects)
		{
			if (Obj.name != RenameString)
			{
				Obj.name = RenameString;
			}
		}

		RenameString = null;
	}







	private void FindAndReplaceNames()
	{
		GUILayout.Space(10f);
		GUILayout.Label("Find & Replace GameObject Names", EditorStyles.boldLabel);

		ShowFindReplace = EditorGUILayout.Foldout(ShowFindReplace, "Options");

		if (ShowFindReplace)
		{
			EditorGUILayout.HelpBox("Enter the string for the name to change, then enter the value you wish to change the objects to and press the button the change them.", MessageType.Info);

			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.PrefixLabel("Find This Name: ");
			FindString = EditorGUILayout.TextField(FindString);
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.PrefixLabel("Replace With This Name: ");
			ReplaceString = EditorGUILayout.TextField(ReplaceString);
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("Replace Names", GUILayout.MaxWidth(105)))
			{
				foreach (GameObject Obj in FindObjectsOfType<GameObject>())
				{
					if (Obj.name == FindString)
					{
						Obj.name = ReplaceString;
					}
				}

				FindString = null;
				ReplaceString = null;
			}
			EditorGUILayout.EndHorizontal();
		}
	}
}
