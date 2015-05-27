using UnityEngine;
using System.Collections;

public class Utilities : MonoBehaviour {
	public GameObject menuView;
	public GameObject mainView;
	public GameObject creditView;
	public GameState gameState;

	void Start () {
		Screen.showCursor = false;
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}

		if (gameState == GameState.Main) {
			creditView.SetActive(false);
			mainView.SetActive (true);
			StartCoroutine (CloseView (menuView));
		} else if (gameState == GameState.Menu) {
			creditView.SetActive(false);
			mainView.SetActive (false);
			menuView.SetActive (true);
		} else if (gameState == GameState.Credits) {
			mainView.SetActive (false);
			menuView.SetActive (false);
			creditView.SetActive(true);
		}
	}

	private IEnumerator CloseView(GameObject view){
		yield return new WaitForSeconds(1);
		view.SetActive (false);
	}
}
