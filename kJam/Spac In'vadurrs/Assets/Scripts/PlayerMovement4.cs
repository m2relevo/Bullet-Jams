﻿using UnityEngine;
using System.Collections;

public class PlayerMovement4 : MonoBehaviour
{
	public float speed;
	public GameObject Bullet;
	public GameObject Projectileposition;
	public bool limit = false;

	// Use this for initialization
	void Start ()
	{
	}

	// Update is called once per frame
	void Update ()
	{	

		float x = Input.GetAxisRaw ("Horizontal_4");
		float y = Input.GetAxisRaw ("Vertical_4");
		Vector2 direction = new Vector2 (x, y).normalized;

		Move (direction);
	}

	void Move (Vector2 direction)
	{

		if (Input.GetKeyDown ("joystick 2 button 5")) //&& limit == false
		{
			if(limit==false)
			    {
			        limit=true;
			        GameObject Projectile = (GameObject)Instantiate (Bullet);
					Projectile.name = "4";
			        Projectile.GetComponent<Projectile>().SetPPT ();
			        Projectile.transform.position = Projectileposition.transform.position;
			    }
			/*limit = true;*/
		}


		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));

		max.x = max.x - 0.225f;
		min.x = min.x + 0.225f;

		Vector2 pos = transform.position;

		pos += direction * speed * Time.deltaTime;

		pos.x = Mathf.Clamp (pos.x, min.x, max.x);

		transform.position = pos;
	}



	public void bulletDead()
	{
		limit = false;
	}
}
