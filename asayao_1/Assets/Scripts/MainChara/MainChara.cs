using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainChara : MonoBehaviour {

	[SerializeField]
	protected GameObject mainChara;
	[SerializeField]
	protected float moveSpeed;
	[SerializeField]
	private float mainCharaHp;
	[SerializeField]
	private float bulletSpeed;
	private const string IDLE	= "Wizard_Idle";
	private const string RUN		= "Wizard_Run";
	private const string ATTACK	= "Wizard_Attack";
	private const string DAMAGE	= "Wizard_Damage";
	private Animation anim;

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

	/**
	* mainCharaの魔法を打つ処理
	*
	*/
	public void attackMainChara(){
		makeBullet();
		mainCharaAnimation(2);
		GameObject bullet = GameObject.Find("Bullet_1");
		bullet.layer = 8;
		Rigidbody rigid =  bullet.GetComponent<Rigidbody>();
		rigid.AddForce(new Vector3(mainChara.transform.forward.x*bulletSpeed,0,mainChara.transform.forward.z*bulletSpeed));
	}

	/**
	* mainCharaの弾を生成する処理
	*/
	protected void makeBullet(){
		if(mainChara == null)mainChara = GameObject.Find("mainChara");
		GameObject bullet = (GameObject)Resources.Load("Bullet/Bullet_1");
		GameObject bulletPrefab = Instantiate(bullet,new Vector3(mainChara.transform.position.x-0.9f,mainChara.transform.position.y+1,mainChara.transform.position.z+0.2f),Quaternion.identity);
    bulletPrefab.transform.SetParent(mainChara.transform);
		bulletPrefab.name = "Bullet_1";
		GameObject bomb = (GameObject)Resources.Load("UI/Bomb!");
		GameObject canvas = GameObject.Find("Canvas");
		GameObject bulletButton = GameObject.Find("bulletButton");
		GameObject bombPrefab = Instantiate(bomb,new Vector3(bulletButton.transform.position.x,bulletButton.transform.position.y+30,bulletButton.transform.position.z),Quaternion.identity) as GameObject;
		bombPrefab.transform.SetParent(canvas.transform);
		bombPrefab.name = "Bomb!";
	}

	/**
	* hpを増やす処理
	* @param hp 増やす量
	*/
	protected void plusHp(float hp){
		mainCharaHp += hp;
	}
	/**
	* hpを減らす処理
	* @param hp 減らす量
	*/
	protected void minusHp(float hp){
		mainCharaHp -= hp;
	}

	/**
	* mainCharaのアニメーション処理
	* @param status 実行するアニメーションの種類 0...IDLE 1...RUN 2...ATTACK 3...DAMAGE
	*/
	protected void mainCharaAnimation(int status){
		anim = mainChara.GetComponent<Animation>();
		switch(status){
			case 0:
			  anim.CrossFade(IDLE);
			  break;
	    case 1:
			  anim.CrossFade(RUN);
			  break;
			case 2:
			  anim.CrossFade(ATTACK);
			  break;
			case 3:
			  anim.CrossFade(DAMAGE);
				break;
		}
	}
}
