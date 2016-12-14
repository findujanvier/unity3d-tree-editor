using UnityEngine;
using UnityEditor;
using System.Collections.Generic;


public class TreeEditorWindow : EditorWindow {
	public static TreeEditorWindow currentWindow;

	ListView listView;
	GraphView graphView;
	PropertiesView propertiesView;

	float listViewWidth = 250f;
	float propertiesViewWidth = 350f;

	public TreeGUI currentTree; // TODO: data struct with scriptableobject

	Vector2 scrollPosition;		// TODO replace with cameraOffset;

	[MenuItem ("Window/TreeEditor")]
	public static void ShowTreeEditorWindow () {
		currentWindow = (TreeEditorWindow)EditorWindow.GetWindow <TreeEditorWindow> ();

	}
	void OnEnable () {
		CreateViews ();
//		currentTree = ScriptableObjectUtils.LoadData <> ();
	}

	void OnFocus () {

	}

	void OnGUI() {
		if (EditorApplication.isCompiling) {
			ShowNotification (new GUIContent("Unity is compiling..."));
			GUI.enabled = false;
		} else {
			GUI.enabled = true;
		}

		if (graphView == null){
			CreateViews ();
		}


		if (currentTree != null) {
			Event e = Event.current;
			ProcessEvent (e);

			scrollPosition = GUI.BeginScrollView (new Rect(0f, 0f, position.width, position.height), scrollPosition, new Rect (0, 0, 2000, 2000));
			BeginWindows ();
			graphView.UpdateView (e, position, currentTree);
			EndWindows ();
			GUI.EndScrollView ();
		}

		GUILayout.BeginHorizontal ();

		// list view
		if (position.width > listViewWidth) {
			GUILayout.BeginVertical ("Box", GUILayout.Width (listViewWidth), GUILayout.ExpandHeight(true));

			GUILayout.BeginHorizontal ();
			if (GUILayout.Button ("Create")) {

			}
			if (GUILayout.Button ("Delete")) {

			}
			if (GUILayout.Button ("Create")) {

			}
			GUILayout.EndHorizontal ();

			EditorGUILayout.LabelField ("Test View");
			for (int i = 0; i < 10; i++) {
				EditorGUILayout.LabelField ("Test " + i);

			}
			GUILayout.EndVertical ();
		}
		// graph view
//		listView.UpdateView (new Rect (0, 0, listViewWidth, position.height));
//		propertiesView.UpdateView (new Rect (position.width - propertiesViewWidth, 0, propertiesViewWidth, position.height));

		GUILayout.FlexibleSpace ();

		// properties view
		if (position.width > listViewWidth + propertiesViewWidth) {
			GUILayout.BeginVertical ("Box", GUILayout.Width (propertiesViewWidth), GUILayout.ExpandHeight(true));
			EditorGUILayout.LabelField ("Test View");
			for (int i = 0; i < 10; i++) {
				EditorGUILayout.LabelField ("Test " + i);

			}
			GUILayout.EndVertical ();
		}
		GUILayout.EndHorizontal ();
	}

	private void CreateViews () {
		if (currentWindow != null) {
			currentWindow.listView = new ListView ();
			currentWindow.graphView = new GraphView ();
			currentWindow.propertiesView = new PropertiesView ();
		} else {
			currentWindow = (TreeEditorWindow)EditorWindow.GetWindow <TreeEditorWindow> ();
		}
	}

	private void ProcessEvent (Event _e){
		if (_e.type == EventType.KeyDown && _e.keyCode == KeyCode.LeftArrow) {
			Debug.Log ("left");
		}
		if (_e.type == EventType.KeyDown && _e.keyCode == KeyCode.RightArrow) {
			Debug.Log ("right");
		}
	}

	private void DrawListView () {

	}

	private void DrawPropertiesView () {

	}
}
