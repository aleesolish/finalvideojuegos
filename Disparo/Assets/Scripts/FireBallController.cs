using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallController : MonoBehaviour {

	public float speed;

	public Player player;

	// Use this for initialization
	void Start () {
		
		player = FindObjectOfType<Player>();

		if (player.transform.localScale.x < 0)
			speed = -speed;
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y); 

	}
}
