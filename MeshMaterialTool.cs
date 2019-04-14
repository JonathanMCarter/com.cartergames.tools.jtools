using UnityEngine;
using UnityEditor;

public class MeshMaterialTool : EditorWindow
{


	[SerializeField]
	private Material ApplyMaterial;

	[SerializeField]
	private Material[] Mats = new Material[0];

	[SerializeField]
	private Material[] SelectMats = new Material[0];

	[SerializeField]
	private Material[] UndoMats = new Material[0];

	public int SelectElementLength;


	private bool IfApplyPressed;


	[MenuItem("Window/MeshMaterialEditor")]
	public static void ShowWindow()
	{
		GetWindow<MeshMaterialTool>("Mesh Material Editor");
	}



	private void OnGUI()
	{
		StartHeader();
		Tool();
	}


	private void StartHeader()
	{
		GUILayout.Space(10f);
		EditorGUILayout.HelpBox("Apply Materials to selected meshes.", MessageType.None);
		GUILayout.Space(10f);
	}



	private void Tool()
	{
		EditorGUILayout.HelpBox("How To Use: \n \n1) Select all the meshes you wish to edit. \nNOTE: all the meshes have the be the same for this tool to work. \n\n2) Press the 'Find' button, open the array dropdown's & wait for the array's to populate. \n\n3) Add material(s) to the 'Select Mats' array in the same element position to the material(s) you wish to edit. \n\n4) When done, press 'Apply' to make the changes.", MessageType.None);

		GUILayout.BeginHorizontal();

		if (GUILayout.Button("Find", GUILayout.MaxWidth(60)))
		{
			FindButton();
		}

		GUI.color = Color.green;

		if (GUILayout.Button("Apply", GUILayout.MaxWidth(60)))
		{
			ApplyButton();
		}

		GUI.color = Color.cyan;

		if (GUILayout.Button("Clear", GUILayout.MaxWidth(60)))
		{
			Material[] TempArray = new Material[0];
			Mats = TempArray;

			Material[] TempArrayV2 = new Material[0];
			SelectMats = TempArrayV2;
		}

		GUI.color = Color.yellow;

		if (GUILayout.Button("Undo Last", GUILayout.MaxWidth(80)))
		{
			UndoButton();
		}

		GUILayout.EndHorizontal();

		ShowArrays();
	}



	private void FindButton()
	{
		if (Mats.Length == 0)
		{
			// Makes the Array 1 Bigger
			Material[] TempArrayPlus1 = new Material[1];
			Mats.CopyTo(TempArrayPlus1, 0);
			Mats = TempArrayPlus1;
		}

		if (Selection.gameObjects.Length == 1)
		{
			foreach (GameObject I in Selection.gameObjects)
			{
				if (I.GetComponent<MeshRenderer>())
				{
					foreach (Material Mat in I.GetComponent<MeshRenderer>().sharedMaterials)
					{
						if (Mats[0] != null)
						{
							// Makes the Array 1 Bigger
							Material[] TempArray = new Material[Mats.Length + 1];
							Mats.CopyTo(TempArray, 0);
							Mats = TempArray;
						}

						Mats[Mats.Length - 1] = Mat;
					}
				}
				else if (I.GetComponentInChildren<MeshRenderer>())
				{
					foreach (Material Mat in I.GetComponentInChildren<MeshRenderer>().sharedMaterials)
					{
						if (Mats[0] != null)
						{
							// Makes the Array 1 Bigger
							Material[] TempArray = new Material[Mats.Length + 1];
							Mats.CopyTo(TempArray, 0);
							Mats = TempArray;
						}

						Mats[Mats.Length - 1] = Mat;
					}
				}
			}
		}
		else
		{
			foreach (GameObject I in Selection.gameObjects)
			{
				if (I.GetComponent<MeshRenderer>())
				{
					foreach (Material Mat in I.GetComponent<MeshRenderer>().sharedMaterials)
					{
						for (int i = 0; i < Mats.Length; i++)
						{
							if (!ArrayUtility.Contains(Mats, Mat))
							{
								if (Mats[0] != null)
								{
									// Makes the Array 1 Bigger
									Material[] TempArray = new Material[Mats.Length + 1];
									Mats.CopyTo(TempArray, 0);
									Mats = TempArray;
								}

								Mats[Mats.Length - 1] = Mat;
							}
						}
					}
				}
				else if (I.GetComponentInChildren<MeshRenderer>())
				{
					foreach (Material Mat in I.GetComponentInChildren<MeshRenderer>().sharedMaterials)
					{
						for (int i = 0; i < Mats.Length; i++)
						{
							if (!ArrayUtility.Contains(Mats, Mat))
							{
								if (Mats[0] != null)
								{
									// Makes the Array 1 Bigger
									Material[] TempArray = new Material[Mats.Length + 1];
									Mats.CopyTo(TempArray, 0);
									Mats = TempArray;
								}

								Mats[Mats.Length - 1] = Mat;
							}
						}
					}
				}
			}
		}

		// Setup Select array tobe the same size as the mats array
		Material[] MatsToSelect = new Material[Mats.Length];
		SelectMats.CopyTo(MatsToSelect, 0);
		SelectMats = MatsToSelect;
	}


	private void ClearArray(Material[] Array)
	{
		for (int i = 0; i < Array.Length; i++)
		{
			Array[i] = null;
		}
	}


	private void ApplyToSelection(Material[] InputArray, Material[] SelectionArray)
	{
		for (int i = 0; i < InputArray.Length; i++)
		{
			if (SelectionArray[i] == null)
			{
				SelectionArray[i] = InputArray[i];
			}
		}

		foreach (GameObject I in Selection.gameObjects)
		{
			if (I.GetComponent<MeshRenderer>())
			{
				UndoMats = I.GetComponent<MeshRenderer>().sharedMaterials;
				I.GetComponent<MeshRenderer>().sharedMaterials = SelectMats;
			}
			else if (I.GetComponentInChildren<MeshRenderer>())
			{
				foreach (MeshRenderer Mesh in I.GetComponentsInChildren<MeshRenderer>())
				{
					UndoMats = Mesh.GetComponent<MeshRenderer>().sharedMaterials;
					Mesh.GetComponentInChildren<MeshRenderer>().sharedMaterials = SelectMats;
				}
			}
		}
	}



	private void UndoMaterials(Material[] InputArray, Material[] UndoArray)
	{
		foreach (GameObject I in Selection.gameObjects)
		{
			if (I.GetComponent<MeshRenderer>())
			{
				I.GetComponent<MeshRenderer>().sharedMaterials = UndoMats;
			}
			else if (I.GetComponentInChildren<MeshRenderer>())
			{
				foreach (MeshRenderer Mesh in I.GetComponentsInChildren<MeshRenderer>())
				{
					Mesh.GetComponentInChildren<MeshRenderer>().sharedMaterials = UndoMats;
				}
			}
		}
	}




	private void ShowArrays()
	{
		GUI.color = Color.white;

		// Bit of code that makes the array visable
		ScriptableObject Target = this;
		SerializedObject SO = new SerializedObject(Target);
		SerializedProperty Array = SO.FindProperty("Mats");

		EditorGUILayout.PropertyField(Array, new GUIContent("Found Materials"), true);
		SO.ApplyModifiedProperties(); 
		// end of bit of code that does the thing stated above

		GUI.color = Color.yellow;

		// Bit of code that makes the array visable
		ScriptableObject Target2 = this;
		SerializedObject SO2 = new SerializedObject(Target2);
		SerializedProperty Array2 = SO2.FindProperty("SelectMats");

		EditorGUILayout.PropertyField(Array2, new GUIContent("Materials To Apply"), true);
		SO2.ApplyModifiedProperties();
		// end of bit of code that does the thing stated above
	}


	private void ApplyButton()
	{
		if (SelectMats != null)
		{
			foreach (GameObject I in Selection.gameObjects)
			{
				if (I.GetComponent<MeshRenderer>())
				{
					ApplyToSelection(I.GetComponent<MeshRenderer>().sharedMaterials, SelectMats);

					IfApplyPressed = true;
				}
				else if (I.GetComponentInChildren<MeshRenderer>())
				{
					foreach (MeshRenderer Mesh in I.GetComponentsInChildren<MeshRenderer>())
					{
						ApplyToSelection(Mesh.GetComponent<MeshRenderer>().sharedMaterials, SelectMats);

						IfApplyPressed = true;
					}
				}
			}
		}


		ClearArray(Mats);
		ClearArray(SelectMats);

		Material[] TempArray = new Material[0];
		Mats = TempArray;

		Material[] TempArrayV2 = new Material[0];
		SelectMats = TempArrayV2;
	}


	private void UndoButton()
	{
		if (IfApplyPressed)
		{
			if (UndoMats != null)
			{
				foreach (GameObject I in Selection.gameObjects)
				{
					if (I.GetComponent<MeshRenderer>())
					{
						UndoMaterials(I.GetComponent<MeshRenderer>().sharedMaterials, UndoMats);

						IfApplyPressed = false;
					}
					else if (I.GetComponentInChildren<MeshRenderer>())
					{
						foreach (MeshRenderer Mesh in I.GetComponentsInChildren<MeshRenderer>())
						{
							UndoMaterials(Mesh.GetComponent<MeshRenderer>().sharedMaterials, UndoMats);

							IfApplyPressed = false;
						}
					}
				}
			}
		}
	}
}
