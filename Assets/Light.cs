using UnityEngine;
using System.Collections;

public class Light : MonoBehaviour {

	public AudioSource cl;
	public GameObject lt,but;
	private int t;
	// Use this for initialization
	void Start () {
		t = 1;
		lt.SetActive (true);
		but.SetActive(false);
		cl.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		t = -t;
		cl.Play ();
		if (t == 1) {
			lt.SetActive (true);
			but.SetActive(false);
		} else {
			lt.SetActive (false);
			but.SetActive(true);
		}
	}
}