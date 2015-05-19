using UnityEngine;
using System.Collections;

public class InformationBehaviour : ObjectInteractable {
	
	void Awake(){
		ObjectExited = HandledObjectExited;

	}

	private void HandledObjectExited (){
		InformationAnimator informationAnimator = gameObject.GetComponent<InformationAnimator> ();
		if (informationAnimator != null)
			informationAnimator.PopUpExit ();
	}
}
