using UnityEngine;
using UnityEditor;

public static class ScriptableObjectUtils {
	
//	[MenuItem("Assets/Create/Skills")]
	public static T Create<T> () where T : ScriptableObject
	{
		T asset = ScriptableObject.CreateInstance<T>();

		AssetDatabase.CreateAsset(asset, "Assets/Resources/Data/skills.asset");
		AssetDatabase.SaveAssets();
		return asset;
	}

	public static T LoadData<T> () where T : ScriptableObject {
		var path = "Assets/Resources/Data/skills.asset";
		var data = AssetDatabase.LoadAssetAtPath (path, typeof(T)) as T;
		return data;
	}
}
