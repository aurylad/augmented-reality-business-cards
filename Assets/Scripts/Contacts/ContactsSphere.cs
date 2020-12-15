using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactsSphere : MonoBehaviour {

	public GameObject infoText;
	public GameObject truck;
	private int count = 0;

	private void OnMouseOver(){
		if (Input.GetMouseButtonDown(0)){
			if (count == 0) {
				infoText.SetActive (true);
				truck.SetActive (false);
				count++;
			} else {
				truck.SetActive (true);
				infoText.SetActive (false);
				count = 0;
			}
		}
	}
}
