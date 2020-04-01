using UnityEngine;
using System.Collections;

public class WaterMapDisplay : MonoBehaviour {

	public MeshFilter meshFilter;
	public MeshRenderer meshRenderer;

	public void DrawMesh(WaterMeshData meshData, Texture2D texture) {
		meshFilter.sharedMesh = meshData.CreateMesh ();
		meshRenderer.sharedMaterial.mainTexture = texture;
	}

}
