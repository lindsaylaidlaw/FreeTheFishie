using UnityEngine;
using System.Collections;

public class Shark : MonoBehaviour {
	public float speed = 3.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += Vector3.left * Time.deltaTime * speed;
	}
}
