using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class Smash : MonoBehaviour {

	bool isHit = false;
	public GameObject centerPiv;
	public ParticleSystem tvSpew;

	public AudioClip glassBreak;
	public AudioClip CRTStartup;
	public AudioClip CRTHum;

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Hammer") {
			if (!isHit) {
				isHit = true;
				print("hit once!");

				gameObject.GetComponent<AudioSource>().PlayOneShot(glassBreak);
				gameObject.GetComponent<AudioSource>().PlayOneShot(CRTStartup);

				gameObject.GetComponent<AudioSource>().loop = true;
				gameObject.GetComponent<AudioSource>().PlayOneShot(CRTHum);

				centerPiv.GetComponent<NoiseAndGrain>().enabled = true;
				centerPiv.GetComponent<BloomOptimized>().enabled = true;

				centerPiv.GetComponent<Grayscale>().enabled = false;

				var main = tvSpew.main;

				main.maxParticles = 100;


				
			}

		}
	}

}
