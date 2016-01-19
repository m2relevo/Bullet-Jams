using UnityEngine;
using System.Collections;

public class ExplosionPattern : MonoBehaviour {

	public float speed = 5f;
	GameObject missile;
	GameObject BossObj;
    GameObject[] Cannonballs;
	
	public void Awake ()
	{
		Cannonballs = new GameObject[10];
		missile = Resources.Load ("BossBullet") as GameObject;
		BossObj = GameObject.FindGameObjectWithTag ("enemy");
		Cannonballs [0] = (GameObject)Instantiate (missile, new Vector3 (-3.92F, -2.91F, 0F), Quaternion.identity);
		Cannonballs [1] = (GameObject)Instantiate (missile, new Vector3 (-1.27F, -1.14F, 0F), Quaternion.identity);
		Cannonballs [2] = (GameObject)Instantiate (missile, new Vector3 (-1.27F, -1.14F, 0F), Quaternion.identity);
		Cannonballs [3] = (GameObject)Instantiate (missile, new Vector3 (-1.27F, -1.14F, 0F), Quaternion.identity);
		Cannonballs [4] = (GameObject)Instantiate (missile, new Vector3 (-1.27F, -1.14F, 0F), Quaternion.identity);
		Cannonballs [5] = (GameObject)Instantiate (missile, new Vector3 (-1.27F, -1.14F, 0F), Quaternion.identity);
		Cannonballs [6] = (GameObject)Instantiate (missile, new Vector3 (-1.27F, -1.14F, 0F), Quaternion.identity);
		Cannonballs [7] = (GameObject)Instantiate (missile, new Vector3 (-1.27F, -1.14F, 0F), Quaternion.identity);
		Cannonballs [8] = (GameObject)Instantiate (missile, new Vector3 (-1.27F, -1.14F, 0F), Quaternion.identity);
		Cannonballs [9] = (GameObject)Instantiate (missile, new Vector3 (-1.27F, -1.14F, 0F), Quaternion.identity);

	}
	// Update is called once per frame
	public void Update () 
	{
		float step = speed * Time.deltaTime;

		    if (Cannonballs[0] != null) 
		    {
			Cannonballs [0].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-3.920F, -2.91F, 0F), step);
			Cannonballs [1].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-2.010F, -2.91F, 0F), step);
			Cannonballs [2].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-0.100F, -2.91F, 0F), step);
			Cannonballs [3].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (1.810F, -2.91F, 0F), step);
			Cannonballs [4].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (3.720F, -2.91F, 0F), step);
			Cannonballs [5].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-3.920F, 2.23F, 0F), step);
			Cannonballs [6].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-2.010F, 2.23F, 0F), step);
			Cannonballs [7].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-0.100F, -2.91F, 0F), step);
			Cannonballs [8].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (1.810F, -2.91F, 0F), step);
			Cannonballs [9].transform.position = Vector3.MoveTowards (transform.position, new Vector3 (3.720F, -2.91F, 0F), step);
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
 