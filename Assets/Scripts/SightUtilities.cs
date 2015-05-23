using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SightUtilities : MonoBehaviour {
	public float speed = 1.5f;
	public List<GameObject> sightPoints;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			MoveChildToUp();
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			MoveChildToDown();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			MoveChildToLeft();
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			MoveChildToRight();
		}
	}

	void MoveChildToUp(){
		foreach (GameObject sightEye in sightPoints) {
			Transform sightTransform = sightEye.transform.GetChild(0);
			sightTransform.position += Vector3.up * speed * Time.deltaTime;
		}
	}

	void MoveChildToDown(){		
		foreach (GameObject sightEye in sightPoints) {
			Transform sightTransform = sightEye.transform.GetChild(0);
			sightTransform.position += Vector3.down * speed * Time.deltaTime;
		}
	}

	void MoveChildToLeft(){	
		foreach (GameObject sightEye in sightPoints) {
			Transform sightTransform = sightEye.transform.GetChild(0);
			sightTransform.position += Vector3.left * speed * Time.deltaTime;
		}
	}

	void MoveChildToRight(){	
		foreach (GameObject sightEye in sightPoints) {
			Transform sightTransform = sightEye.transform.GetChild(0);
			sightTransform.position += Vector3.right * speed * Time.deltaTime;
		}
	}
}
