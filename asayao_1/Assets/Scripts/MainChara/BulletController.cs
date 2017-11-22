using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MainChara {
	[SerializeField]
	private GameObject explosion;

	// Use this for initialization
	void Start () {
		explosion = (GameObject)Resources.Load("Bullet/Animation/Explosion");

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision obj){
		Debug.Log("**** onCollisionenter");
		makeBullet();
		Instantiate(explosion,this.gameObject.transform.position,Quaternion.identity);
		Destroy(this.gameObject);
	}

	public void bulletShot(){
		Debug.Log("**** bullet shot ");
		mainChara = GameObject.Find("mainChara");
		attackMainChara();
	}
}
