using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPick : MonoBehaviour {


	public int pointsToAdd;


	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Player> () == null)
			return;

		ScoreManager.AddPoints (pointsToAdd);

		Destroy (gameObject);
	}
}
