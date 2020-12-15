using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwiterSphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	private void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			Application.OpenURL("https://twitter.com/ar_card");
		}
	}
}
