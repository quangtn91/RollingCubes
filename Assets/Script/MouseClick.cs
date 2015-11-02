using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour {
	public float clickDeltaTime = 0.35f; //Max time to consider click in a chain
	bool isFirstClick = true;
	float clickTime; //Time between clicks
	public float speedUpBy = 100f;
	public float speedDownBy = 50f;
	int click = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float currentTime = Time.time;
		if (click == 3) {
			TripleClick();
		}
		if (click == 2 && currentTime > (clickTime + clickDeltaTime)) {
			DoubleClick();
		}
		if (click == 1 && currentTime > (clickTime + clickDeltaTime)) {
			SingleClick();
		}
	}

	void OnMouseUp(){
		if (isFirstClick) {
			click++;
			isFirstClick = false;
		}
		if (Time.time <= (clickTime + clickDeltaTime)) {
			click++;
		}
		clickTime = Time.time;
	}

	void SingleClick(){
		Rotator.speed = 90f;
		click = 0;
		isFirstClick = true;
	}
	
	void DoubleClick(){
		if (Rotator.speed >= 3e+38f) {
			Rotator.speed = float.MaxValue;
		}else
			Rotator.speed += speedUpBy;
		click = 0;
		isFirstClick = true;
	}
	
	void TripleClick(){
		if (Rotator.speed > 0) {
			Rotator.speed -= speedDownBy;
		}
		if (Rotator.speed < 0) {
			Rotator.speed = 0;
		}
		click = 0;
		isFirstClick = true;
	}
}
