using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseSleepListener : MonoBehaviour {
	public float maxIdleTime = 5;
	private float timeCount = 0;
	private Vector3 lastMousePosition = Vector3.zero;
	public GameObject pauseView;
	public GameObject scrollMap;
	public Utilities utilities;
	// Update is called once per frame
	void Update () {
		if (utilities.gameState == GameState.Main) {
		
			if (lastMousePosition == Input.mousePosition) {
				timeCount += Time.deltaTime;
				if (timeCount > maxIdleTime) {
					ActivePauseView();
				}
			} else {
				timeCount = 0;
			}
		}

		lastMousePosition = Input.mousePosition;
	}

	private void ActivePauseView(){
		if (scrollMap != null) {
			scrollMap.SetActive(false);
		}
		if (pauseView != null) {
			pauseView.SetActive (true);
		}
	}
}
