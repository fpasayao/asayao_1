using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MainChara {
	[SerializeField]
	private GameObject explosion;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision obj){
		Debug.Log("**** onCollisionenter");
		makeBullet();
		explosion = (GameObject)Resources.Load("Bullet/Animation/Explosion");
		Instantiate(explosion,this.gameObject.transform.position,Quaternion.identity);
		Destroy(this.gameObject);
	}
}
