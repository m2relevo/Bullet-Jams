using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour 
{
	bool Attacking = false;
	// Use this for initialization
	void Start () 
	{
		this.gameObject.AddComponent<ExplosionPattern>();
		Attacking = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Attacking == false) 
		{
			this.gameObject.AddComponent<ExplosionPattern>();
		}
	}

	public void scriptFinished()
	{
		Destroy (this.gameObject.GetComponent<ExplosionPattern>());
		Attacking = false;
	}
}
