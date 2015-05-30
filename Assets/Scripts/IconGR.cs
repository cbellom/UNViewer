using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class IconGR : ObjectInteractable {
	public GameObject informationView;
	public Information information;
	
	public GameObject dataList;
	public GameObject dataPrefab;
	
	void Awake(){
		ObjectSelected = HanldeObjectSelected;
	}
	
	private void HanldeObjectSelected(){		
		SetPrefabInformation ();
		ActiveAnimationOpenInformtionView ();
		gameObject.SetActive (false);
		
	}
	
	private void ActiveAnimationOpenInformtionView(){
		InformationAnimator informationAnimator = informationView.GetComponent<InformationAnimator> ();
		if (informationAnimator != null)
			informationAnimator.PopUpOpen ();
	}
	
	
	private void SetPrefabInformation(){
		Text preTitleText = GetChildOfPrefabByName ("Name").GetComponent<Text> () as Text;
		preTitleText.text = information.preTitle;
		
		CreateDataList (information.dataList);
		
		Text descriptionText = GetChildOfPrefabByName ("Description").GetComponent<Text> () as Text;
		descriptionText.text = information.description;
		Image pictureOf = GetChildOfPrefabByName ("Photo").GetComponent<Image> () as Image;
		pictureOf.sprite = information.photo;
	}
	
	private Transform GetChildOfPrefabByName (string name)	{
		return informationView.gameObject.transform.FindChild (name);
	}
	
	private void CreateDataList(List<Data> dataList){
		EraseDataList ();
		foreach (Data data in dataList) {
			GameObject newItem = Instantiate(dataPrefab) as GameObject;
			newItem.transform.SetParent(this.dataList.gameObject.transform, false);
			newItem.GetComponent<Text>().text = "<color=#6fa15c>"+ data.type+"</color> <color=#ffffff>"+data.value+"</color>";
		}
	}
	
	private void EraseDataList(){
		foreach (Transform child in dataList.transform) {
			Destroy (child.gameObject);
		}
	}
}
