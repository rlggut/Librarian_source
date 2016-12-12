using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public int num;
	public GameObject sf;
	private int i;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		if (num == 0) {
			PlayerPrefs.SetInt ("Fire", 0);
			sf.SetActive(false);
		}
		if(num==1)
		{
			i=PlayerPrefs.GetInt ("Fire_stuff");
			PlayerPrefs.SetInt ("money",PlayerPrefs.GetInt ("money")-1);
			for(;i<PlayerPrefs.GetInt ("Cards");i++)
			{
				PlayerPrefs.SetInt ("Player"+i.ToString(),PlayerPrefs.GetInt ("Player"+(i+1).ToString()));
				PlayerPrefs.SetInt ("PlayerWork"+i.ToString(),PlayerPrefs.GetInt ("PlayerWork"+(i+1).ToString()));
			}
			PlayerPrefs.SetInt ("PlayerWork"+PlayerPrefs.GetInt ("Cards").ToString(),0);
			PlayerPrefs.SetInt ("Cards",PlayerPrefs.GetInt ("Cards")-1);
			PlayerPrefs.SetInt ("Fire", 0);
			sf.SetActive(false);
		}
	}
}