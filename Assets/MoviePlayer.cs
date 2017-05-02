using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviePlayer : MonoBehaviour {

	public MovieTexture movie;
	
	void Start() {
		GetComponent<Renderer>().material.mainTexture = movie;
		movie.loop = true;
		movie.Play();
	}
}
