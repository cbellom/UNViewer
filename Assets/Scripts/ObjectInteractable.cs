using UnityEngine;
using UnityEngine.UI;
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

	public Sprite imageIconNormal;
	public Sprite imageIconOnFocus;
	public Sprite imageIconVisited;

	private bool isVisited;

	void Start(){
		sight = GameObject.Find("Sight");
		canTriggerExit = true;
		isVisited = false;
		SetImageIcon (imageIconNormal);
	}

	void OnTriggerEnter2D(Collider2D other) {
		elapsedTime = 0;
		isTriggerActivate = false;
		SetImageIcon (imageIconOnFocus);
	}
	
	void OnTriggerStay2D(Collider2D other) {
		if (!isTriggerActivate) {
			elapsedTime += Time.deltaTime;
			if (elapsedTime >= timeToTriggerAction) {
				isTriggerActivate = true;
				isVisited = true;
				SetImageIcon (imageIconVisited);
				if(ObjectSelected != null)
					ObjectSelected();
			}
		}
	}
	
	void OnTriggerExit2D(Collider2D other) {
		if (canTriggerExit) {
			elapsedTime = 0;
			isTriggerActivate = false;

			if(!isVisited)
				SetImageIcon (imageIconNormal);
			else
				SetImageIcon (imageIconVisited);

			if (ObjectExited != null)
				ObjectExited ();
		}
	}

	public void SetObjectSelectedAction(Action HandleAction){
		ObjectSelected = HandleAction;
	}

	public void SetImageIcon(Sprite image){
		if(image != null)
			gameObject.GetComponent<Image> ().sprite = image;
	}

}
