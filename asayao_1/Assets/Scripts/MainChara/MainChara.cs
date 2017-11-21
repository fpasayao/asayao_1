using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChara : MonoBehaviour {

	[SerializeField]
	protected GameObject mainChara;
	[SerializeField]
	protected float moveSpeed;

	/**
	* mainCharaの移動処理
	* @param status 移動する方向
	*/
	protected void moveMainChara(Vector2 movePosition){
		if(movePosition.x >= 50)movePosition.x = 50;
		else if(movePosition.x <= -50) movePosition.x = -50;
		if(movePosition.y >= 50)movePosition.y = 50;
		else if(movePosition.y <= -50)movePosition.y = -50;
		mainChara.transform.LookAt(new Vector3(movePosition.x,0,movePosition.y));
    mainChara.transform.position += new Vector3(movePosition.x/moveSpeed,0,movePosition.y/moveSpeed);
	}
}
