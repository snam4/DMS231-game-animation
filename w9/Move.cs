using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public Color startColor;
	public Color endColor;
	public Renderer rend;
	public float x;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {
		
		//animation 
		//this.transform.position = new Vector3 (transform.position.x,transform.position.y + Time.deltaTime *2 ,transform.position.z); 
		//Debug.Log (transform.position.y * Time.deltaTime *2);
		rend.material.color = startColor;

		if (Input.GetAxis ("Fire1") == 1) {
			rend.material.color = endColor;
		}

		//if (condition) {
		// CODE
		//}
	}
}
