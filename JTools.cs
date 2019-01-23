using UnityEngine;
using UnityEditor;

public class JTools : EditorWindow
{

	private string RenameString;
	private bool ShowRenameGameObject;





	[MenuItem("Window/J-Tools")]
	public static void ShowWindow()
	{
		GetWindow<JTools>("J-Tools");
	}


	private void OnGUI()
	{
		GUILayout.Space(10f);
		GUILayout.Label("J-Tools", EditorStyles.boldLabel);
		GUILayout.Label("A random selection of tools that may or may not be useful. This is mostly for fun :)");



		GUILayout.Space(10f);
		GUILayout.Label("Rename Objects", EditorStyles.boldLabel);

		ShowRenameGameObject = EditorGUILayout.Foldout(ShowRenameGameObject, "Open Options");

		if (ShowRenameGameObject)
		{
			GUILayout.BeginHorizontal();

			RenameString = EditorGUILayout.TextField("Name String Value", RenameString);

			if (GUILayout.Button("Change Name"))
			{
				RenameObject();
			}

			GUILayout.EndHorizontal();
		}

	}


	private void RenameObject()
	{
		foreach (GameObject Obj in Selection.gameObjects)
		{
			if (Obj.name != RenameString)
			{
				Obj.name = RenameString;
			}
		}
	}
}
