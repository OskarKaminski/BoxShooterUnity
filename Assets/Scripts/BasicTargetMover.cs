using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {

	public float spinSpeed = 100.0f;
	public float motionMagnitude = 0.1f;

	public bool addSpinning = true;
	public bool addMagnitude = false;
	
	void Update () {
		if (this.addSpinning)
			this.spin ();
		if (this.addMagnitude)
			this.move ();
	}

	void spin () {
		this.gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
	}

	void move(){
		this.gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
	}
}
