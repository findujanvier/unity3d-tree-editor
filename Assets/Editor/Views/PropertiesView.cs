using UnityEngine;

public class PropertiesView : ViewBase {

	public PropertiesView () : base () {
		Debug.Log ("construct properties view");
	}

	public override void UpdateView (Event e, Rect rect, TreeGUI currentTree)
	{
		base.UpdateView (e, rect, currentTree);

//		GUI.Button (rect, "button");
		GUI.BeginGroup (rect);
		DrawBox (rect);


		Debug.Log ("update properties view");

		GUI.EndGroup ();
	}

	void DrawBox (Rect rect) {
		Color oldColor = GUI.color;

		GUI.color = Color.gray;

		GUI.Box (new Rect (0, 0, rect.width, rect.height), "");

		GUI.color = oldColor;
	}
}
