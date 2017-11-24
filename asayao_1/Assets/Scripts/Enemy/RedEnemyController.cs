using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyController : Enemy {
	Animator enemyAnimator;
	private int stateAttack;
	private int stateIdle;
	private int stateRun;
	private bool isAttackState;
	[SerializeField]
	private GameObject arm;
	private GameObject attackObjPrefab;
	// Use this for initialization
	void Start () {
		enemyAnimator = GetComponent<Animator>();
		this.stateAttack = Animator.StringToHash("Base Layer.Attack");
		this.stateIdle = Animator.StringToHash("Base Layer.Idle");
		this.stateRun = Animator.StringToHash("Base Layer.Run");
		isAttackState = false;

	}

	void Update(){

		if(Input.GetKey("up")){
			enemyAnimator.SetTrigger("Attack");
		}

		if(enemyAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == this.stateAttack && isAttackState == false){
			isAttackState = true;
			GameObject attackObj = (GameObject)Resources.Load("Enemy/AttackObj");
			attackObjPrefab = Instantiate(attackObj) as GameObject;
			attackObjPrefab.name = "AttackObj";
			attackObjPrefab.transform.SetParent(arm.transform);
			attackObjPrefab.transform.position = arm.transform.position;
		}

		if(enemyAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == this.stateIdle || enemyAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == this.stateRun && isAttackState == true){
			Destroy(attackObjPrefab);
			isAttackState = false;
		}

	}

	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.name == "Bullet_1"){
		  minusHp(obj.gameObject.GetComponent<BulletController>().getBulletDamage());
	  }
	}


}
