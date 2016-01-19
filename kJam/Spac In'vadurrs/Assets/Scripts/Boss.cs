using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour 
{
	
	// Use this for initialization
	void Start () 
	{
		this.gameObject.AddComponent<ExplosionPattern>();
		//Attacking = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.gameObject.AddComponent<ExplosionPattern> ();

	}

	public void scriptFinished()
	{

		Destroy (this.gameObject.GetComponent<ExplosionPattern>());

	}
}
