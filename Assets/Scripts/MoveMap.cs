using UnityEngine;
using System.Collections;

public class MoveMap : MonoBehaviour {
	public float speed;
	private Vector3 start;
	private Vector3 position;
	public float deltaMove;
	public float deltaToMoveX;
	public float deltaToMoveY;
	public float wayToMoveX;
	public float wayToMoveY;
	public bool canMoveMap;
	// Use this for initialization
	void Start () {
		start = transform.position;
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (canMoveMap) {
			position = transform.position;
			position.x += wayToMoveX;
			position.y += wayToMoveY;
			position.z = 0;
			Camera.main.ScreenToWorldPoint (position);
			
			transform.position = Vector3.Lerp (transform.position, position, speed * Time.deltaTime);
			if(wayToMoveX != 0){
				float delta = (wayToMoveX > 0) ? deltaMove:-deltaMove;
				deltaToMoveX = wayToMoveX + delta;
			}if(wayToMoveY != 0){
				float delta = (wayToMoveY > 0) ? deltaMove:-deltaMove;
				deltaToMoveY = wayToMoveY + delta;
			}
		}
	}
}
