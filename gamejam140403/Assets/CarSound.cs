using UnityEngine;
using System.Collections;

public class CarSound : MonoBehaviour {

	public float maxPitch = 3f;
	
	void Start () {

	}
	
	void Update () {
		        float pitch = 0.1f;


				pitch = speed.sspd / 350 + 0.1f;
				if (pitch > maxPitch) {
					pitch = maxPitch;
				}

		
		audio.pitch = pitch;
	}
}
