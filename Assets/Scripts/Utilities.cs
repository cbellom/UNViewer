using UnityEngine;
using System.Collections;

public class Utilities : MonoBehaviour {
	public GameObject menuView;
	public GameObject mainView;
	public GameState gameState;

	void Start () {
		Screen.showCursor = false;
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}

		if (gameState == GameState.Main) {
			mainView.SetActive(true);
			StartCoroutine(CloseView(menuView));
		} else if (gameState == GameState.Main) {
			mainView.SetActive(false);
			menuView.SetActive(true);
		}
	}

	private IEnumerator CloseView(GameObject view){
		yield return new WaitForSeconds(2);
		view.SetActive (false);
	}
}
