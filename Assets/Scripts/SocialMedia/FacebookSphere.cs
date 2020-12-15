using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacebookSphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	private void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			Application.OpenURL("https://www.facebook.com/AR-Business-Card-264035730832966/?modal=admin_todo_tour");
		}
	}
}
