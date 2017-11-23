using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MainChara {
	[SerializeField]
	private GameObject explosion;
	public bool isBulletShot = false;
	[SerializeField]
	private float bulletDamage;

	// Use this for initialization
	void Start () {
		explosion = (GameObject)Resources.Load("Bullet/Animation/Explosion");
	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.layer != this.gameObject.layer)return;
		bulletExplosion();
	}

	/**
	* 弾を爆発させる処理
	*/
	public void bulletExplosion(){
		GameObject bulletShot = GameObject.Find("bulletButton");
		bulletShot.GetComponent<BulletController>().isBulletShot = false;
		if(this.gameObject.name == "Bullet_1"){
		  Instantiate(explosion,this.gameObject.transform.position,Quaternion.identity);
		  Destroy(this.gameObject);
	  }else if(this.gameObject.name == "Bomb!"){
			GameObject bullet = GameObject.Find("Bullet_1");
			Instantiate(explosion,bullet.transform.position,Quaternion.identity);
			Destroy(bullet);
		}
		GameObject bomb = GameObject.Find("Bomb!");
		Destroy(bomb);
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

	/**
	* 弾の攻撃力を取得
	*/
	public float getBulletDamage(){
		return this.bulletDamage;
	}
}
