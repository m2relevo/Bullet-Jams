using UnityEngine;
using System.Collections;

public class ExplosionPattern : MonoBehaviour {

	public float speed = 2f;
	GameObject BossBullet;
	public GameObject BossObj;
    GameObject[] Cannonballs;
	

	// Update is called once per frame
	void Update () 
	{

		   GameObject BossBullet  = Resources.Load("BossBullet") as GameObject;
				Cannonballs = new GameObject[10];
		if (BossBullet != null) {
			for (int i = 0; i<Cannonballs.Length; i++) {
				Cannonballs [i] = (GameObject)Instantiate (BossBullet);
			}
			Cannonballs [0].transform.position = new Vector3 (-3.92F, -2.91F, 0F);
			Cannonballs [1].transform.position = new Vector3 (-1.27F, -1.14F, 0F);
			Cannonballs [2].transform.position = new Vector3 (-1.27F, -1.14F, 0F);
			Cannonballs [3].transform.position = new Vector3 (-1.27F, -1.14F, 0F);
			Cannonballs [4].transform.position = new Vector3 (-1.27F, -1.14F, 0F);
			Cannonballs [5].transform.position = new Vector3 (-1.27F, -1.14F, 0F);
			Cannonballs [6].transform.position = new Vector3 (-1.27F, -1.14F, 0F);
			Cannonballs [7].transform.position = new Vector3 (-1.27F, -1.14F, 0F);
			Cannonballs [8].transform.position = new Vector3 (-1.27F, -1.14F, 0F);
			Cannonballs [9].transform.position = new Vector3 (-1.27F, -1.14F, 0F);
		

			Cannonballs [0].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-3.920F, -2.91F, 0F), speed * Time.deltaTime);
			Cannonballs [1].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-2.010F, -2.91F, 0F), speed * Time.deltaTime);
			Cannonballs [2].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-0.100F, -2.91F, 0F), speed * Time.deltaTime);
			Cannonballs [3].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (1.810F, -2.91F, 0F), speed * Time.deltaTime);
			Cannonballs [4].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (3.720F, -2.91F, 0F), speed * Time.deltaTime);
			Cannonballs [5].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-3.920F, 2.23F, 0F), speed * Time.deltaTime);
			Cannonballs [6].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-2.010F, 2.23F, 0F), speed * Time.deltaTime);
			Cannonballs [7].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-0.100F, -2.91F, 0F), speed * Time.deltaTime);
			Cannonballs [8].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (1.810F, -2.91F, 0F), speed * Time.deltaTime);
			Cannonballs [9].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (3.720F, -2.91F, 0F), speed * Time.deltaTime);
		}
		if (Cannonballs [0] == null) 
		{
			endScript();
		}
	}
	void endScript()
	{
		this.gameObject.GetComponent<Boss> ().scriptFinished ();
	}

}
 