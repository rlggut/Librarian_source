using UnityEngine;
using System.Collections;

public class Next_step : MonoBehaviour {
	public int day;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		day = PlayerPrefs.GetInt ("day");
		if((PlayerPrefs.GetInt ("day")==60)&&(PlayerPrefs.GetInt ("money")>0)) Application.LoadLevel("Good_end");
	}
	void OnMouseDown()
	{
		if ((PlayerPrefs.GetInt ("day") % 7) == 5) {
			PlayerPrefs.SetInt ("day", PlayerPrefs.GetInt ("day") + 3);
			PlayerPrefs.SetInt ("money",PlayerPrefs.GetInt ("money")-PlayerPrefs.GetInt ("Cards"));


			PlayerPrefs.SetInt ("1", 0);
			PlayerPrefs.SetInt("1cash",0);
			PlayerPrefs.SetInt("1bibl",0);

			PlayerPrefs.SetInt ("2", 0);
			PlayerPrefs.SetInt("2prog",0);
			PlayerPrefs.SetInt("2bibl",0);
		}
		else
			PlayerPrefs.SetInt ("day", PlayerPrefs.GetInt ("day") + 1);

		PlayerPrefs.SetInt ("PickStuff", 0);
		PlayerPrefs.SetInt ("PlayerWork1", 0);
		PlayerPrefs.SetInt ("PlayerWork2", 0);
		PlayerPrefs.SetInt ("PlayerWork3", 0);
		PlayerPrefs.SetInt ("PlayerWork4", 0);
		PlayerPrefs.SetInt ("PlayerWork5", 0);
		PlayerPrefs.SetInt ("PlayerWork6", 0);
	}
}