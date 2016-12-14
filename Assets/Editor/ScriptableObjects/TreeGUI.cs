using UnityEngine;
using System.Collections.Generic;

public class TreeGUI : ScriptableObject {
	List<NodeGUI> nodes;

	NodeGUI selectedNode;
	public void UpdateTreeGUI (Event e, Rect rect) {
		if (nodes.Count > 0) {
			ProcessEvents (e, rect);
			for (int i = 0; i < nodes.Count; i++) {
				nodes [i].UpdateNodeGUI (e, rect);
			}
		}
	}

	private void ProcessEvents (Event e, Rect viewRect) {
		if (viewRect.Contains (e.mousePosition)) {
			if (e.button == 0) {
				if (e.type == EventType.MouseDown) {

					selectedNode = null;

					for (int i = 0; i < nodes.Count; i++) {
						if (nodes [i].nodeRect.Contains (e.mousePosition)) {
							nodes [i].isSelected = true;
							selectedNode = nodes [i];
						}
					}
				}
			}
		}
	}
}
