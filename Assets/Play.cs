using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public GameObject fail;
	public GameObject c1,c2,c3,c4,c5,c6;
	public int cards;
	private int i,x,t;
	// Use this for initialization
	void Start () {
		t = -1;
	}
	
	// Update is called once per frame
	void Update () {
		if ((PlayerPrefs.GetInt ("money") < 0)&&(t==-1)) {
			t = 150;
			fail.SetActive (true);
		}
		if(t==0) Application.LoadLevel("Bad_end");
		if(t>0) t--;

		cards = PlayerPrefs.GetInt ("Cards");
		if(PlayerPrefs.GetInt ("Cards")>=1) c1.SetActive(true);
		else c1.SetActive(false);

		if(PlayerPrefs.GetInt ("Cards")>=2) c2.SetActive(true);
		else c2.SetActive(false);
	
		if(PlayerPrefs.GetInt ("Cards")>=3) c3.SetActive(true);
		else c3.SetActive(false);
	
		if(PlayerPrefs.GetInt ("Cards")>=4) c4.SetActive(true);
		else c4.SetActive(false);

		if(PlayerPrefs.GetInt ("Cards")>=5) c5.SetActive(true);
		else c5.SetActive(false);
	
		if(PlayerPrefs.GetInt ("Cards")>=6) c6.SetActive(true);
		else c6.SetActive(false);
	}
}