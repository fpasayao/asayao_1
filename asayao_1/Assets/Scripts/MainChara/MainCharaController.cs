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
		GameObject camera = GameObject.Find("Main Camera");
		camera.AddComponent<CameraController>();
	}

	void Update () {
		/*
		if(Input.touchCount > 0){
			Touch firstFinger = Input.GetTouch(0);
			switch(firstFinger.phase){
				case TouchPhase.Began:
				  firstPosition = firstFinger.position;
				  break;
				case TouchPhase.Moved:
				  secondPosition = firstFinger.position;
					mainCharaAnimation(1);
					moveMainChara(secondPosition-firstPosition);
				  break;
				case TouchPhase.Stationary:
				  mainCharaAnimation(1);
				  moveMainChara(secondPosition);
				  break;
				case TouchPhase.Ended:
				  mainCharaAnimation(0);
					attackMainChara();
				  break;
			}
		}
		*/

		//パソコン用の操作
		Rigidbody rigid = mainChara.GetComponent<Rigidbody>();
		if(Input.GetKey("up")){
			rigid.AddForce(new Vector3(0,0,10));
		}else if(Input.GetKey("down")){
			rigid.AddForce(new Vector3(0,0,-10));
		}else if(Input.GetKey("right")){
			rigid.AddForce(new Vector3(10,0,0));
		}else if(Input.GetKey("left")){
			rigid.AddForce(new Vector3(-10,0,0));
		}

	}
}
