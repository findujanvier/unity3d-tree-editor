using UnityEngine;
using UnityEditor;

public class ListView : ViewBase {

	float padding = 10f;

	GUIStyle actionBarGS;

	public GUIStyle ActionBarGS {
		get {
			actionBarGS = new GUIStyle ();
			actionBarGS.padding = new RectOffset (5,5,5,5);
			return this.actionBarGS;
		}
	}

	public ListView () : base ()
	{
		Debug.Log ("construct list view");
	}

	public override void UpdateView (Event e, Rect rect, TreeGUI currentTree)
	{
		base.UpdateView (e, rect, currentTree);

		float innerWidth = rect.width - (padding * 2f);
		float innerHeight = rect.height - (padding * 2f);

		GUI.BeginGroup (rect);	// List Group

		DrawListViewBackGround (rect);
		Debug.Log ("update list view");
		float x = 0f;
		GUI.BeginGroup (new Rect (padding, padding, innerWidth, 50), ActionBarGS);
		EditorGUILayout.LabelField ("Test");
		Color oldColor = GUI.color;

		GUI.color = Color.green;

		GUI.Box (new Rect (0, 0, innerWidth, 50), "");

		GUI.color = oldColor;

		for (int i = 0; i < 3; i++) {
			if (GUI.Button (new Rect (x, 0f, 40f, 20f), "test")) {

			}
			x += 44f;
		}
		GUI.EndGroup ();
//		float y = 0f;
//		for (int i = 0; i < 5; i++) {
//			GUI.BeginGroup (new Rect (0f, y, 250f, rect.height));
//			GUI.Button (new Rect (0f, 0f, 30f, 20f), "test");
//			GUI.EndGroup ();
//			y += 24f;
//		}

		GUI.EndGroup ();
	}

	void DrawListViewBackGround (Rect rect) {
		Color oldColor = GUI.color;

		GUI.color = Color.gray;

		GUI.Box (new Rect (0, 0, rect.width, rect.height), "");

		GUI.color = oldColor;
	}
}
