using UnityEngine;


public class ViewBase {

	protected Rect viewRect;
	protected TreeGUI currentTree;

	public ViewBase ()
	{
		Debug.Log ("construct view base");
	}
	
	public virtual void UpdateView (Event e, Rect rect, TreeGUI currentTree) {
		
		this.currentTree = currentTree;

	}
}
