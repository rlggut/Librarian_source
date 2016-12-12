using UnityEngine;
using System.Collections;

public class SetStuff : MonoBehaviour {
	
	public int card_num;
	public GameObject fire;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown()
	{
		//Если карточка не на дело
	/*	if (1 != 1) {
		}
		else
		{*/
			if(PlayerPrefs.GetInt ("Fire")== 0)
			{
				PlayerPrefs.SetInt ("Fire_stuff", card_num);
				PlayerPrefs.SetInt ("Fire", 1);
			fire.SetActive(true);
			}
		//}
	}
}