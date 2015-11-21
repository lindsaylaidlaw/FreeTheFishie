using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject prefab;
	public float spawnTime;

	float time;
	float globalTime;

	// Use this for initialization
	void Start () {
		Debug.Log ("tesssst");
	}
	
	// Update is called once per frame
	void Update () {
		if (time > spawnTime) {
			Spawn ();
			spawnTime = 2.0f + UnityEngine.Random.value * 2.0f;

			time = 0;
		}

		transform.localPosition = new Vector3 (transform.localPosition.x, 
		                                  Mathf.Sin (globalTime * 4 * Mathf.PI),
		                                  transform.localPosition.z);

		globalTime += Time.deltaTime;
		time += Time.deltaTime;

	}

	void Spawn() {
		var instance = GameObject.Instantiate (prefab);
		instance.transform.position = transform.position;
	}
}
