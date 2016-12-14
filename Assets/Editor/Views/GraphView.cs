using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class GraphView : ViewBase {
//	List<Rect> windowRects = new List<Rect>();

	public GraphView () : base ()
	{
//		windowRects.Add (new Rect(50, 50 , 200, 200));
//		windowRects.Add (new Rect(150, 50 , 200, 200));
//		windowRects.Add (new Rect(250, 50 , 200, 200));

		Debug.Log ("construct graph view");
	}


	public override void UpdateView (Event e, Rect rect, TreeGUI currentTree)
	{
		base.UpdateView (e, rect, currentTree);

		currentTree.UpdateTreeGUI (e, rect);
//		for (int i = 0; i < 3; i++) {
//			windowRects[i] = GUI.Window (i, windowRects[i], DrawNodeWindow, "window");
//		}
	}
	void DrawNodeWindow (int windowId) {
		GUILayout.BeginVertical ();
		EditorGUILayout.LabelField ("test window");
		GUILayout.EndVertical ();
		GUI.DragWindow ();
	}
}
