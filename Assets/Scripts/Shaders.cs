using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaders : MonoBehaviour {

	public Material EffectMaterial;

	void OnRenderImage(RenderTexture src, RenderTexture dst) {
		Graphics.Blit(src, dst, EffectMaterial);
	}
}
