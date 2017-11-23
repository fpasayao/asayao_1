using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	[SerializeField]
	private float enemyHp;
	[SerializeField]
	private GameObject enemyObject;

	/**
	* hpを増やす処理
	* @param hp 増やす量
	*/
	protected void plusHp(float hp){
		enemyHp += hp;
	}

	/**
	* hpを減らす処理
	* @param hp 減らす量
	*/
	protected void minusHp(float hp){
		Debug.Log("**** enemyhp -> " + hp);
		enemyHp -= hp;
		if(enemyHp <= 0.0f){
			destroyObj();
		}
	}

	protected void destroyObj(){
		Destroy(enemyObject);
	}




}
