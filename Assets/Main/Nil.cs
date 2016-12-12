using UnityEngine;
using System.Collections;

public class Nil : MonoBehaviour {

	public int max_card;
	private int i;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("day", 0);

		PlayerPrefs.SetInt ("Cards", 0);
		PlayerPrefs.SetInt ("money", 10);
		PlayerPrefs.SetInt ("PickStuff", 0);
		PlayerPrefs.SetInt ("Fire", 0);
		
		PlayerPrefs.SetInt ("PlayerWork1", 0);
		PlayerPrefs.SetInt ("PlayerWork2", 0);
		PlayerPrefs.SetInt ("PlayerWork3", 0);
		PlayerPrefs.SetInt ("PlayerWork4", 0);
		PlayerPrefs.SetInt ("PlayerWork5", 0);
		PlayerPrefs.SetInt ("PlayerWork6", 0);
		
		PlayerPrefs.SetInt ("Player1", 0);
		PlayerPrefs.SetInt ("Player2", 0);
		PlayerPrefs.SetInt ("Player3", 0);
		PlayerPrefs.SetInt ("Player4", 0);
		PlayerPrefs.SetInt ("Player5", 0);
		PlayerPrefs.SetInt ("Player6", 0);


		for (i=0; i<=max_card; i++) {
			PlayerPrefs.SetInt (i.ToString (), 0);
			PlayerPrefs.SetInt(i.ToString()+"pr",0);
			PlayerPrefs.SetInt(i.ToString()+"prog",0);
			PlayerPrefs.SetInt(i.ToString()+"bibl",0);
			PlayerPrefs.SetInt(i.ToString()+"cash",0);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
