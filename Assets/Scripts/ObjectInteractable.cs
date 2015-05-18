using UnityEngine;
using System;
using System.Collections;

public class ObjectInteractable : MonoBehaviour {
	[SerializeField]
	protected float timeToTriggerAction;
	protected float elapsedTime;
	protected bool isTriggerActivate;
	protected bool canTriggerExit;
	protected GameObject worldCollider;
	private GameObject sight;

	protected Action ObjectSelected;
	protected Action ObjectExited;

	void Start(){
		sight = GameObject.Find("Sight");
		canTriggerExit = true;
	}

	void OnTriggerEnter2D(Collider2D other) {
		elapsedTime = 0;
		isTriggerActivate = false;
	}
	
	void OnTriggerStay2D(Collider2D other) {
		if (!isTriggerActivate) {
			elapsedTime += Time.deltaTime;
			if (elapsedTime >= timeToTriggerAction) {
				isTriggerActivate = true;
				if(ObjectSelected != null)
					ObjectSelected();
			}
		}
	}
	
	void OnTriggerExit2D(Collider2D other) {
		if (canTriggerExit) {
			elapsedTime = 0;
			isTriggerActivate = false;
			if (ObjectExited != null)
				ObjectExited ();
		}
	}

	public void SetObjectSelectedAction(Action HandleAction){
		ObjectSelected = HandleAction;
	}

}
