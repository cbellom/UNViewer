using UnityEngine;
using System.Collections;

public class InformationAnimator : MonoBehaviour {
	private Animator animator;
	public GameObject navigationAreas;

	void Awake(){
		animator = GetComponent<Animator> ();
	}

	public void PopUpOpen(){
		animator.SetBool ("Open", true);
		navigationAreas.SetActive (false);
	}

	public void PopUpExit(){
		animator.SetBool ("Open", false);
		navigationAreas.SetActive (true);
	}
}
