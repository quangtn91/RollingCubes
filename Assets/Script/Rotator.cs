using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	Vector3 v;
	public static float speed = 90f; //Angular speed

	// Use this for initialization
	void Start () {
		float x = Random.Range(-360,360);
		float y = Random.Range(-360,360);
		float z = Random.Range(-360,360);
		v = new Vector3 (x, y, z);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (v, speed * Time.deltaTime);
	}
}
