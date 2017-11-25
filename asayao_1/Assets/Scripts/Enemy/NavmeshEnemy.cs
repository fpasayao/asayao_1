using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshEnemy : MonoBehaviour {
	GameObject mainChara;
	GameObject enemy;
	bool isNavEnemy;

	// Use this for initialization
	void Start () {
		mainChara = GameObject.Find("mainChara");
		enemy = this.gameObject.transform.root.gameObject;
		isNavEnemy = false;

	}

	// Update is called once per frame
	void Update () {
		if(isNavEnemy == true){
			enemy.GetComponent<NavMeshAgent>().SetDestination(mainChara.transform.position);
		}else{
			enemy.GetComponent<NavMeshAgent>().SetDestination(enemy.transform.position);
		}


	}

	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.name == "collision"){
			isNavEnemy = true;
			enemy.GetComponent<Animator>().SetBool("isRun",true);
		}
	}

	void OnTriggerExit(Collider obj){
		if(obj.gameObject.name == "collision"){
			isNavEnemy = false;
			enemy.GetComponent<Animator>().SetBool("isRun",false);

		}
	}
}
