using UnityEngine;
using System.Collections;

public class Go_lvl : MonoBehaviour {

	public string nam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		if(nam!="Exit") Application.LoadLevel(nam);
		else Application.Quit();
	}
}
