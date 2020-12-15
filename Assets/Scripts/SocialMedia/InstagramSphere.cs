using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstagramSphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	private void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			Application.OpenURL("https://www.instagram.com/ar_business_card/?hl=en");
		}
	}
}
