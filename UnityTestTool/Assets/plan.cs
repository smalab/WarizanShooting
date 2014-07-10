using UnityEngine;
using System.Collections;

public class plan : MonoBehaviour {

	public int aa;
	// Use this for initialization
	public plan (int number) {
		aa=number;
	}
	
	// Update is called once per frame
	public int DoubleIt () {
		return aa*2;
	}
}
