using UnityEngine;
using System.Collections;

public class ShowStuff : MonoBehaviour {

	public int num;
	public GameObject c1,c2,c3,c4,nope;
	// Use this for initialization
	void Start () {
	
	}
	void nil()
	{
		c1.SetActive (false);c2.SetActive (false);c3.SetActive (false);c4.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		nil ();
		if(PlayerPrefs.GetInt ("Player"+num.ToString())==1) c1.SetActive(true);
		if(PlayerPrefs.GetInt ("Player"+num.ToString())==2) c2.SetActive(true);
		if(PlayerPrefs.GetInt ("Player"+num.ToString())==3) c3.SetActive(true);
		if(PlayerPrefs.GetInt ("Player"+num.ToString())==4) c4.SetActive(true);

		if(PlayerPrefs.GetInt ("PlayerWork"+num.ToString())==1)nope.SetActive(true);
		else nope.SetActive(false);
	}
}