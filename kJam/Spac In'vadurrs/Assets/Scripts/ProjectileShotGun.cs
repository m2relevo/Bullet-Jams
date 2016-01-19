using UnityEngine;
using System.Collections;

public class ProjectileShotGun : MonoBehaviour {
	
	public float speed = 2.5f;
	GameObject missile;
	GameObject BossObj;
	GameObject[] ShotGunShells;
	
	public void Awake ()
	{
		ShotGunShells = new GameObject[10];
		missile = Resources.Load ("BossBulletGreen") as GameObject;
		BossObj = GameObject.FindGameObjectWithTag ("enemy");
		ShotGunShells [0] = (GameObject)Instantiate (missile, new Vector3 (-2.27F, -1.83F, 0F), Quaternion.identity);
		ShotGunShells [1] = (GameObject)Instantiate (missile, new Vector3 (-1.95F, -2.09F, 0F), Quaternion.identity);
		ShotGunShells [2] = (GameObject)Instantiate (missile, new Vector3 (-1.5F, -2.16F, 0F), Quaternion.identity);
		ShotGunShells [3] = (GameObject)Instantiate (missile, new Vector3 (-1.0F, -2.09F, 0F), Quaternion.identity);
		ShotGunShells [4] = (GameObject)Instantiate (missile, new Vector3 (-0.62F, -1.83F, 0F), Quaternion.identity);
		ShotGunShells [5] = (GameObject)Instantiate (missile, new Vector3 (-2.27F, -1.33F, 0F), Quaternion.identity);
		ShotGunShells [6] = (GameObject)Instantiate (missile, new Vector3 (-1.95F, -0.97F, 0F), Quaternion.identity);
		ShotGunShells [7] = (GameObject)Instantiate (missile, new Vector3 (-1.5F, -0.86F, 0F), Quaternion.identity);
		ShotGunShells [8] = (GameObject)Instantiate (missile, new Vector3 (-1.0F, -0.97F, 0F), Quaternion.identity);
		ShotGunShells [9] = (GameObject)Instantiate (missile, new Vector3 (-0.62F, -1.33F, 0F), Quaternion.identity);
	}
	// Update is called once per frame
	public void Update () 
	{
		float step = speed * Time.deltaTime; 
		if(ShotGunShells[0] != null)
			ShotGunShells [0].transform.position = Vector3.MoveTowards (ShotGunShells[0].transform.position, new Vector3 (-2.27F, -5.0F, 0F), step);
		if(ShotGunShells[1] != null)
			ShotGunShells [1].transform.position = Vector3.MoveTowards (ShotGunShells[1].transform.position, new Vector3 (-1.95F, -5.0F, 0F), step);
		if(ShotGunShells[2] != null)
			ShotGunShells [2].transform.position = Vector3.MoveTowards (ShotGunShells[2].transform.position, new Vector3 (-1.5F, -5.0F, 0F), step);
		if(ShotGunShells[3] != null)
			ShotGunShells [3].transform.position = Vector3.MoveTowards (ShotGunShells[3].transform.position, new Vector3 (-1.0F, -5.0F, 0F), step);
		if(ShotGunShells[4] != null)
			ShotGunShells [4].transform.position = Vector3.MoveTowards (ShotGunShells[4].transform.position, new Vector3 (-0.62F, -5.0F, 0F), step);
		if(ShotGunShells[5] != null)
			ShotGunShells [5].transform.position = Vector3.MoveTowards (ShotGunShells[5].transform.position, new Vector3 (-2.27F, 5.0F, 0F), step);
		if(ShotGunShells[6] != null)
			ShotGunShells [6].transform.position = Vector3.MoveTowards (ShotGunShells[6].transform.position, new Vector3 (-1.95F, 5.0F, 0F), step);
		if(ShotGunShells[7] != null)
			ShotGunShells [7].transform.position = Vector3.MoveTowards (ShotGunShells[7].transform.position, new Vector3 (-1.5F, 5.0F, 0F), step);
		if(ShotGunShells[8] != null)
			ShotGunShells [8].transform.position = Vector3.MoveTowards (ShotGunShells[8].transform.position, new Vector3 (-1.0F, 3.0F, 0F), step);
		if(ShotGunShells[9] != null)
			ShotGunShells [9].transform.position = Vector3.MoveTowards (ShotGunShells[9].transform.position, new Vector3 (-0.62F, 3.0F, 0F), step);

		int j = 0;
		for (int i = 0; i<10; i++) 
		{
			if (ShotGunShells [i] == null) 
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
		this.gameObject.GetComponent<Boss> ().scriptFinished2 ();
	}
	
}
