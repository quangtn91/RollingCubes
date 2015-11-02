using UnityEngine;
using System.Collections;

public class CubeManager : MonoBehaviour {
	public GameObject cube;                            
	public Transform startPoint;
	public uint numberOfCubes = 200;
	public uint cubesPerLine = 20;
	public float distance = 1.2f;

	// Use this for initialization
	void Start () {
		uint line = 0;
		for (uint i = 0; i < numberOfCubes/cubesPerLine; i++) {
			Vector3 pos = startPoint.position;
			pos.z += line * distance;
			for (uint j = 0; j < cubesPerLine; j++) {
				Instantiate (cube, pos, Quaternion.identity);
				pos.x += distance;
			}
			line++;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
