using UnityEngine;
using System.Collections;

public class Utilities : MonoBehaviour {
	public GameObject menuView;
	public GameObject mainView;
	public GameObject creditView;
	public GameObject loadingView;
	public GameState gameState;
	private GameState currentState;

	void Start () {
		Cursor.visible = false;
		currentState = gameState;
		StartCoroutine (CloseView (loadingView, 0.5f));
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}

		if (currentState != gameState) {
			loadingView.SetActive(true);
			if (gameState == GameState.Main) {
				creditView.SetActive(false);
				menuView.SetActive (false);
			} else if (gameState == GameState.Menu) {
				mainView.SetActive (false);
				creditView.SetActive(false);
			} else if (gameState == GameState.Credits) {
				mainView.SetActive (false);
				menuView.SetActive (false);
			}
			StartCoroutine (CloseView (loadingView, 0.5f));
			currentState = gameState;
		}

		if (gameState == GameState.Main) {
			mainView.SetActive (true);
		} else if (gameState == GameState.Menu) {
			menuView.SetActive (true);
		} else if (gameState == GameState.Credits) {
			creditView.SetActive(true);
		}
	}

	private IEnumerator CloseView(GameObject view, float time){
		yield return new WaitForSeconds(time);
		view.SetActive (false);
	}
}
