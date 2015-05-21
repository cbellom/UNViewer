using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IconDC : ObjectInteractable {
	
	public GameObject curiousView;
	public Information information;

	void Awake(){
		ObjectSelected = HanldeObjectSelected;
	}
	
	private void HanldeObjectSelected(){		
		SetPrefabInformation ();
		ActiveAnimationOpenInformtionView ();
		
	}
	
	private void ActiveAnimationOpenInformtionView(){
		InformationAnimator informationAnimator = curiousView.GetComponent<InformationAnimator> ();
		if (informationAnimator != null)
			informationAnimator.PopUpOpen ();
	}
	
	
	private void SetPrefabInformation(){
		Text titleText = GetChildOfPrefabByName ("Title").GetComponent<Text> () as Text;
		titleText.text = information.title;
	}
	
	private Transform GetChildOfPrefabByName (string name)	{
		return curiousView.gameObject.transform.FindChild (name);
	}
}
