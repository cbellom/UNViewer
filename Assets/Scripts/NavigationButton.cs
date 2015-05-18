using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NavigationButton : ObjectInteractable {
	public MoveMap moveMap;

	void Awake(){
		ObjectSelected = HandleObjectSelected;
	}

	private void HandleObjectSelected(){
		position = Input.mousePosition;
		Camera.main.ScreenToWorldPoint (position);
		Vector2 mousePosition = new Vector2 (position.x, position.y);
		mScrollRect.normalizedPosition = Vector2.Lerp( mScrollRect.normalizedPosition, mousePosition, speed * Time.deltaTime );
	}

	private Vector3 GetDifferenceDirection(){
		if (directionState == DirectionState.Up)
			return new Vector3 (0, -deltaMovementScroll, 0);
		if (directionState == DirectionState.Down)
			return new Vector3 (0, deltaMovementScroll, 0);
		if (directionState == DirectionState.Rigth)
			return new Vector3 (-deltaMovementScroll, 0, 0);
		if (directionState == DirectionState.Left)
			return new Vector3 (deltaMovementScroll, 0, 0);

		return new Vector3 (0, 0, 0);
	}
}
