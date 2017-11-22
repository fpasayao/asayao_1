using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MainChara {
	[SerializeField]
	private GameObject explosion;
	public bool isBulletShot = false;

	// Use this for initialization
	void Start () {
		explosion = (GameObject)Resources.Load("Bullet/Animation/Explosion");

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.layer != this.gameObject.layer)return;
		Instantiate(explosion,this.gameObject.transform.position,Quaternion.identity);
		GameObject bulletShot = GameObject.Find("bulletButton");
		bulletShot.GetComponent<BulletController>().isBulletShot = false;
		Destroy(this.gameObject);
	}

	/**
	* 弾を撃つ処理
	*/
	public void bulletShot(){
		mainChara = GameObject.Find("mainChara");
		if(isBulletShot == false){
			attackMainChara();
		  isBulletShot = true;
		}
	}
}
