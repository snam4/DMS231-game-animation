using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {
	public Renderer rend;
	private Color color = new Color(0.5F, 0.5F, 0.5F, 0.5F);
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		rend.material.color = color;
	}
	
	void OnMouseOver() { 
		color.g = 1.0f;
		this.transform.Rotate (Vector3.up, 45 * Time.deltaTime);
	}
	void OnMouseExit()  {
		color.g = 0.5f;
	}
	
}
