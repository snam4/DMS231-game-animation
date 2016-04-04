using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public GameObject coin;
	public float timer = 0.0f;
	private Vector3 spawn_position; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log (timer);
		timer = timer + Time.deltaTime;
		if (timer > 10) {
			timer = 0.0f;
			SpawnCoin ();
		}
	}

	void SpawnCoin(){
		spawn_position = new Vector3(Random.Range(0F, 20.0F), 0.5f, Random.Range(0F, 20.0F));

		Instantiate (coin, spawn_position, Quaternion.Euler (new Vector3 (0, 0, 90)));

	}
}
