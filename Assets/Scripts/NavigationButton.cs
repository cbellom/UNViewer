using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NavigationButton : ObjectInteractable {
	public MoveMap moveMap;
	public DirectionState directionState;

	void Awake(){
		ObjectSelected = HandleObjectSelected;
		ObjectExited = HandleObjectExited;
	}

	private void HandleObjectSelected(){
		moveMap.canMoveMap = true;
		ChangeDeltaMove ();
		elapsedTime = timeToTriggerAction - 0.05f;
		isTriggerActivate = false;
	}

	void HandleObjectExited ()	{
		moveMap.canMoveMap = false;
		moveMap.wayToMoveY = 0;
		moveMap.wayToMoveX = 0;
	}

	private void ChangeDeltaMove(){
		if (directionState == DirectionState.Up) {
			moveMap.wayToMoveY = -1;
		}else if (directionState == DirectionState.Down) {
			moveMap.wayToMoveY = 1;
		}else if (directionState == DirectionState.Rigth){
			moveMap.wayToMoveX = -1;
		}else if (directionState == DirectionState.Left) {
			moveMap.wayToMoveX = 1;
		}
	}
}
