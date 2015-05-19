using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Icon : ObjectInteractable {
	public GameObject informationView;
	public Information information;
	
	void Awake(){
		ObjectSelected = HanldeObjectSelected;
	}
	
	private void HanldeObjectSelected(){		
		SetPrefabInformation ();
		ActiveAnimationOpenInformtionView ();

	}
	
	private void ActiveAnimationOpenInformtionView(){
		InformationAnimator informationAnimator = informationView.GetComponent<InformationAnimator> ();
		if (informationAnimator != null)
			informationAnimator.PopUpOpen ();
	}
	
	private void SetPrefabLocation(){
	}
	
	private void SetPrefabInformation(){
		Text preTitleText = GetChildOfPrefabByName ("PreTitle").GetComponent<Text> () as Text;
		preTitleText.text = information.preTitle;
		Text titleText = GetChildOfPrefabByName ("Title").GetComponent<Text> () as Text;
		titleText.text = information.title;
		Text descriptionText = GetChildOfPrefabByName ("Description").GetComponent<Text> () as Text;
		descriptionText.text = information.description;
		Image pictureOf = GetChildOfPrefabByName ("Photo").GetComponent<Image> () as Image;
		pictureOf.sprite = information.photo;
	}

	private Transform GetChildOfPrefabByName (string name)	{
		return informationView.gameObject.transform.FindChild (name);
	}
}
