using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackController : MonoBehaviour {
	private bool iscollision;

	// Use this for initialization
	void Start () {
		iscollision = false;

	}

	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter(Collider obj){
		if(obj.name == "collision" && iscollision==false){
			iscollision = true;
		}
	}
}
