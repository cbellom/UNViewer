using UnityEngine;
using System.Collections;

public class GoToMouse : MonoBehaviour {
	public float speed;
	public Vector3 target;
	public Vector3 start;
	private Vector3 position;
	// Use this for initialization
	void Start () {
		start = transform.position;
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position = Input.mousePosition;
		position.z = 0;
		Camera.main.ScreenToWorldPoint (position);

		transform.position = Vector3.Lerp (transform.position, position, speed * Time.deltaTime);
	}
}
