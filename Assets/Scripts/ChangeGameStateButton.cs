using UnityEngine;
using System.Collections;

public class ChangeGameStateButton : ObjectInteractable {

	public GameState state;
	public Utilities utilities;

	void Awake(){
		ObjectSelected = HandledObjectSelected;
	}
	
	private void HandledObjectSelected (){
		utilities.gameState = state;
	}
}
