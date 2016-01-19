﻿using UnityEngine;
using System.Collections;

public class EnemyProj : MonoBehaviour {

	public PlayerMovement PM;
	public PlayerMovement2 PM2;
	public PlayerMovement3 PM3; 
	public PlayerMovement4 PM4;
	public PlayerManager PMan;
	int[] Lifes;
	// Use this for initialization
	void Start () 
	{
		Lifes = new int[5];
		PMan = GameObject.Find("Manager").GetComponent<PlayerManager>();
		Lifes = PMan.lifeCheck();
		bool[] pCheck = new bool[PMan.maxPCount];
		pCheck = PMan.playerCheck ();
		if(pCheck[0] == true && Lifes[0] < 3)
			PM = GameObject.Find("P1").GetComponent<PlayerMovement>();
		if(pCheck[1] == true && Lifes[1] < 3)
			PM2 = GameObject.Find("P2").GetComponent<PlayerMovement2>();
		if(pCheck[2] == true && Lifes[2] < 3)
			PM3 = GameObject.Find("P3").GetComponent<PlayerMovement3>();
		if(pCheck[3] == true && Lifes[3] < 3)
			PM4 = GameObject.Find("P4").GetComponent<PlayerMovement4>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		string objName = col.gameObject.name;
		if (objName == "P1") 
		{
			col.gameObject.GetComponent<PlayerMovement> ().enabled = !col.gameObject.GetComponent<PlayerMovement> ().enabled;
		}
		if (objName== "P2") 
		{
			col.gameObject.GetComponent<PlayerMovement> ().enabled = !col.gameObject.GetComponent<PlayerMovement> ().enabled;
		}
		if (objName== "P3") 
		{
			col.gameObject.GetComponent<PlayerMovement> ().enabled = !col.gameObject.GetComponent<PlayerMovement> ().enabled;
		}
		if (objName == "P4") 
		{
			col.gameObject.GetComponent<PlayerMovement> ().enabled = !col.gameObject.GetComponent<PlayerMovement> ().enabled;
		}
		
		col.gameObject.SetActive (false);
		PMan.playerDead (objName);
		Destroy (this.gameObject);
		Debug.Log ("PLAYER HIT BY ENEMY");


		if (objName == "1") 
		{
			PM.bulletDead ();
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		}
		
		if (objName == "2") 
		{
			PM2.bulletDead ();
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		}

		
		if (objName == "3") 
		{
			PM3.bulletDead ();
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		}

		
		if (objName == "4") 
		{
			PM4.bulletDead ();
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		}



	}
}
