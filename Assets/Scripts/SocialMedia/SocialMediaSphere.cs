using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialMediaSphere : MonoBehaviour {

	private int count = 0;
	Animator sociaMedialAnimation;

	void Start(){
		sociaMedialAnimation = GetComponent<Animator> ();
	}

	private void OnMouseOver(){
		if (Input.GetMouseButtonDown(0)){
			if (count == 0) {
				sociaMedialAnimation.Play ("forward");
				count++;
			} else {
				sociaMedialAnimation.Play ("backward");
				count = 0;
			}
		}
	}



}
