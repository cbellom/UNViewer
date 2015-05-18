using UnityEngine;
using System.Collections;

public class MoveMap : MonoBehaviour {
	public float speed;
	private Vector3 start;
	private Vector3 position;
	public float deltaMoveX;
	public float deltaMoveY;
	public bool canMoveMap;
	// Use this for initialization
	void Start () {
		start = transform.position;
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (canMoveMap) {
			position = Input.mousePosition;
			position.x += deltaMoveX;
			position.y += deltaMoveY;
			position.z = 0;
			Camera.main.ScreenToWorldPoint (position);
			
			transform.position = Vector3.Lerp (transform.position, position, speed * Time.deltaTime);
			Debug.Log ("d : " + position);
			deltaMoveX++;
		}
	}
}
