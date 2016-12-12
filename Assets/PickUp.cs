using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	public int clas;//1- пиарщик 2- программист 3- библиотекарь 4-кассир
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		if((PlayerPrefs.GetInt ("PickStuff")== 0)&&(PlayerPrefs.GetInt ("Cards")<6))
		{
			PlayerPrefs.SetInt("Player"+(PlayerPrefs.GetInt ("Cards")+1).ToString(),clas);
			PlayerPrefs.SetInt ("Cards",PlayerPrefs.GetInt ("Cards")+1);
			PlayerPrefs.SetInt ("PickStuff", 1);

			PlayerPrefs.SetInt ("PlayerWork"+PlayerPrefs.GetInt ("Cards"), 0);


			PlayerPrefs.SetInt ("trigst", -PlayerPrefs.GetInt ("trigst"));
			PlayerPrefs.SetInt ("trigst_time", 15);
		}
	}
}