using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour 
{
	float timer;
	float SGtimer;
	public double shotGunTimer = 1.5;
	public double FireRate = 0.1;
	
	// Use this for initialization
	void Start () 
	{
		timer = Time.time;
		SGtimer = Time.time;
		this.gameObject.AddComponent<ExplosionPattern>();
		this.gameObject.AddComponent<ProjectileShotGun>();
		//Attacking = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
	    float elapsed = Time.time - timer;
		float SGelapsed = Time.time - SGtimer;
		if (elapsed > FireRate) 
		{
			this.gameObject.AddComponent<ExplosionPattern> ();
			timer = Time.time;
		}
		if (SGelapsed > shotGunTimer) {
			fireShotgun();
			SGtimer = Time.time;
		}

	}
	public void fireShotgun()
	{
		this.gameObject.AddComponent<ProjectileShotGun> ();
	}

	public void scriptFinished()
	{
		Destroy (this.gameObject.GetComponent<ExplosionPattern>());

	}

	public void scriptFinished2()
	{

		Destroy (this.gameObject.GetComponent<ProjectileShotGun>());
	}
}
