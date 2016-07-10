using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	public float velocity;

	Rigidbody rb;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (0, 0, velocity, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
