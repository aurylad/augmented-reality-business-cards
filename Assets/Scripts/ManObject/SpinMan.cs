using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMan : MonoBehaviour {

	public float speed = 10f;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (Vector3.up, speed * Time.deltaTime);
		transform.Rotate( new Vector3(0, 0, 0.5f), Space.Self );
	}


}
