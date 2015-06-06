using UnityEngine;
using System.Collections;

public class ButtonPauseView : ObjectInteractable {
	
	public GameState state;
	public GameObject pauseView;
	public GameObject scrollMap;
	public Utilities utilities;
	
	void Awake(){
		ObjectSelected = HandledObjectSelected;
	}
	
	private void HandledObjectSelected (){
		if (scrollMap != null) {
			scrollMap.SetActive(true);
		}
		if (pauseView != null) {
			pauseView.SetActive (false);
		}
		utilities.gameState = state;
	}
}
