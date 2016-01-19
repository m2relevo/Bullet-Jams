using UnityEngine;
using System.Collections;

public class ExplosionPattern : MonoBehaviour {

	public float speed = 2f;
	GameObject missile;
	GameObject BossObj;
    GameObject[] Cannonballs;
	
	public void Awake ()
	{
		Cannonballs = new GameObject[10];
		missile = Resources.Load ("BossBullet") as GameObject;
		BossObj = GameObject.FindGameObjectWithTag ("enemy");
		Cannonballs [0] = (GameObject)Instantiate (missile, new Vector3 (-2.27F, -1.83F, 0F), Quaternion.identity);
		Cannonballs [1] = (GameObject)Instantiate (missile, new Vector3 (-1.95F, -2.09F, 0F), Quaternion.identity);
		Cannonballs [2] = (GameObject)Instantiate (missile, new Vector3 (-1.5F, -2.16F, 0F), Quaternion.identity);
		Cannonballs [3] = (GameObject)Instantiate (missile, new Vector3 (-1.0F, -2.09F, 0F), Quaternion.identity);
		Cannonballs [4] = (GameObject)Instantiate (missile, new Vector3 (-0.62F, -1.83F, 0F), Quaternion.identity);
		Cannonballs [5] = (GameObject)Instantiate (missile, new Vector3 (-2.27F, -1.33F, 0F), Quaternion.identity);
		Cannonballs [6] = (GameObject)Instantiate (missile, new Vector3 (-1.95F, -0.97F, 0F), Quaternion.identity);
		Cannonballs [7] = (GameObject)Instantiate (missile, new Vector3 (-1.5F, -0.86F, 0F), Quaternion.identity);
		Cannonballs [8] = (GameObject)Instantiate (missile, new Vector3 (-1.0F, -0.97F, 0F), Quaternion.identity);
		Cannonballs [9] = (GameObject)Instantiate (missile, new Vector3 (-0.62F, -1.33F, 0F), Quaternion.identity);

	}
	// Update is called once per frame
	public void Update () 
	{
		float step = speed * Time.deltaTime; 
		if(Cannonballs[0] != null)
		Cannonballs [0].transform.position = Vector3.MoveTowards (Cannonballs[0].transform.position, new Vector3 (-3.920F, -5.0F, 0F), step);
		if(Cannonballs[1] != null)
			Cannonballs [1].transform.position = Vector3.MoveTowards (Cannonballs[1].transform.position, new Vector3 (-2.010F, -5.0F, 0F), step);
		if(Cannonballs[2] != null)
			Cannonballs [2].transform.position = Vector3.MoveTowards (Cannonballs[2].transform.position, new Vector3 (-0.100F, -5.0F, 0F), step);
		if(Cannonballs[3] != null)
			Cannonballs [3].transform.position = Vector3.MoveTowards (Cannonballs[3].transform.position, new Vector3 (1.810F, -5.0F, 0F), step);
		if(Cannonballs[4] != null)
			Cannonballs [4].transform.position = Vector3.MoveTowards (Cannonballs[4].transform.position, new Vector3 (3.720F, -5.0F, 0F), step);
		if(Cannonballs[5] != null)
			Cannonballs [5].transform.position = Vector3.MoveTowards (Cannonballs[5].transform.position, new Vector3 (-3.920F, 3.0F, 0F), step);
		if(Cannonballs[6] != null)
			Cannonballs [6].transform.position = Vector3.MoveTowards (Cannonballs[6].transform.position, new Vector3 (-2.010F, 3.0F, 0F), step);
		if(Cannonballs[7] != null)
			Cannonballs [7].transform.position = Vector3.MoveTowards (Cannonballs[7].transform.position, new Vector3 (-0.100F, 3.0F, 0F), step);
		if(Cannonballs[8] != null)
			Cannonballs [8].transform.position = Vector3.MoveTowards (Cannonballs[8].transform.position, new Vector3 (1.810F, 3.0F, 0F), step);
		if(Cannonballs[9] != null)
			Cannonballs [9].transform.position = Vector3.MoveTowards (Cannonballs[9].transform.position, new Vector3 (3.720F, 3.0F, 0F), step);
		   
		int j = 0;
		for (int i = 0; i<10; i++) 
		{
			if (Cannonballs [i] == null) 
			{
				j++;
			}
		}
		if(j == 10)
		{
			endScript();
		}
	}

	void endScript()
	{
		this.gameObject.GetComponent<Boss> ().scriptFinished ();
	}

}
 