using UnityEngine;
using System.Collections;

public class HP : MonoBehaviour {



  public static int hp;

  void Awake()
   {
       hp = 300;
   }

	  

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	this.guiText.text = "HP : " + hp;
	}
}
