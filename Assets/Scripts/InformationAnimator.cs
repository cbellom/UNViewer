using UnityEngine;
using System.Collections;

public class InformationAnimator : MonoBehaviour {
	private Animator animator;

	void Awake(){
		animator = GetComponent<Animator> ();
	}

	public void PopUpOpen(){
		animator.SetBool ("Open", true);
	}

	public void PopUpExit(){
		animator.SetBool ("Open", false);
	}
}
