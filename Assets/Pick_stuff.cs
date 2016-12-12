using UnityEngine;
using System.Collections;

public class Pick_stuff : MonoBehaviour {

	public GameObject c1,c2,c3,c4;
	public GameObject ok,nope;
	private int t,num;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("trigst", -1);
		PlayerPrefs.SetInt ("trigst_time", 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("PickStuff") == 1) {
			nope.SetActive (true);
			ok.SetActive (false);
		}
		else nope.SetActive(false);

		if (PlayerPrefs.GetInt ("trigst_time") > 0) {
			c1.transform.position=c1.transform.position+new Vector3(PlayerPrefs.GetInt ("trigst")*1*0.8f,0,0);
			c2.transform.position=c2.transform.position+new Vector3(PlayerPrefs.GetInt ("trigst")*2*0.8f,0,0);
			c3.transform.position=c3.transform.position+new Vector3(PlayerPrefs.GetInt ("trigst")*3*0.8f,0,0);
			c4.transform.position=c4.transform.position+new Vector3(PlayerPrefs.GetInt ("trigst")*4*0.8f,0,0);
			PlayerPrefs.SetInt ("trigst_time", PlayerPrefs.GetInt ("trigst_time")-1);
		}
	}
	void OnMouseDown()
	{
		if ((PlayerPrefs.GetInt ("trigst_time") == 0)&&(PlayerPrefs.GetInt ("trigpr")== -1)&&(PlayerPrefs.GetInt ("trigt")== -1)) {
			PlayerPrefs.SetInt ("trigst", -PlayerPrefs.GetInt ("trigst"));
			ok.SetActive(!ok.activeSelf);
			PlayerPrefs.SetInt ("trigst_time", 15);
		}
	}
}