using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenEnemyController : Enemy {

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.name == "Bullet_1"){
		  minusHp(obj.gameObject.GetComponent<BulletController>().getBulletDamage());
	  }
	}

}
