using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotosSphere : MonoBehaviour {

	public GameObject canvasObject;

	void Start () {
		canvasObject.SetActive(false);
	}

	private void OnMouseOver(){
		if (Input.GetMouseButtonDown(0)){
			//canvasObject.GetComponent<Canvas> ().enabled = true;
			canvasObject.SetActive(true);
			Debug.Log("Mouse is ckicked");
		}
	}

	public void closeReview(){
		canvasObject.SetActive(false);
	}
}
