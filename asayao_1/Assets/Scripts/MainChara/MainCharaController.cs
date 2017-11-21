using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainCharaController : MainChara {
	private Vector2 firstPosition;
	private Vector2 secondPosition;

	void Start(){
		firstPosition = new Vector2(0,0);
		secondPosition = new Vector2(0,0);
	}

	void Update () {
		if(Input.touchCount > 0){
			Touch firstFinger = Input.GetTouch(0);
			switch(firstFinger.phase){
				case TouchPhase.Began:
				  firstPosition = firstFinger.position;
				  break;
				case TouchPhase.Moved:
				  secondPosition = firstFinger.position;
					moveMainChara(secondPosition-firstPosition);
				  break;
				case TouchPhase.Stationary:
				  moveMainChara(secondPosition);
				  break;
				case TouchPhase.Ended:
				  break;
			}
		}
	}
}
