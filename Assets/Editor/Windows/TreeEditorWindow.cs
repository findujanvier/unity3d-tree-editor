using UnityEngine;
using UnityEditor;

public class TreeEditorWindow : EditorWindow {
	public static TreeEditorWindow currentWindow;

	// TODO: data struct with scriptableobject
	[MenuItem ("Window/TreeEditor")]
	public static void ShowTreeEditorWindow () {
		currentWindow = (TreeEditorWindow)EditorWindow.GetWindow <TreeEditorWindow> ();

	}
	void OnEnable () {

	}
	void OnFocus () {

	}

	void OnGUI() {

	}
}
