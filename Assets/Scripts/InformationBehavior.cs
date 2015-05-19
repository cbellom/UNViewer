using UnityEngine;
using System.Collections;

public class InformationBehavior : ObjectInteractable {
	
	void Awake(){
		ObjectExited = HandledObjectExited;

	}

	private void HandledObjectExited (){
		InformationAnimator informationAnimator = gameObject.GetComponent<InformationAnimator> ();
		if (informationAnimator != null)
			informationAnimator.PopUpExit ();
	}
}
