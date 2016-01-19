using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour 
{
	float timer;
	public double FireRate = 0.1;
	
	// Use this for initialization
	void Start () 
	{
		timer = Time.time;
		this.gameObject.AddComponent<ExplosionPattern>();
		//Attacking = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
	    float elapsed = Time.time - timer;
		if (elapsed > FireRate) 
		{
			this.gameObject.AddComponent<ExplosionPattern> ();
			timer = Time.time;
		}

	}

	public void scriptFinished()
	{

		Destroy (this.gameObject.GetComponent<ExplosionPattern>());

	}
}
