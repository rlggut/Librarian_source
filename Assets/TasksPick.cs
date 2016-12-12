using UnityEngine;
using System.Collections;

public class TasksPick : MonoBehaviour {
	public GameObject p1,p2;
	public GameObject ok;
	private int t,num;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("trigt", -1);
		PlayerPrefs.SetInt ("trigt_time", 0);
		ok.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt ("3")== 1) p2.SetActive(true);
		else p2.SetActive(false);

		if (PlayerPrefs.GetInt ("trigt_time") > 0) {
			p1.transform.position=p1.transform.position+new Vector3(-PlayerPrefs.GetInt ("trigt")*1*0.8f,0,0);
			p2.transform.position=p2.transform.position+new Vector3(-PlayerPrefs.GetInt ("trigt")*2*0.8f,0,0);
			PlayerPrefs.SetInt ("trigt_time", PlayerPrefs.GetInt ("trigt_time")-1);
		}
	}
	void OnMouseDown()
	{
		if ((PlayerPrefs.GetInt ("trigt_time") == 0)&&(PlayerPrefs.GetInt ("trigst")== -1)&&(PlayerPrefs.GetInt ("trigpr")== -1)) {
			PlayerPrefs.SetInt ("trigt", -PlayerPrefs.GetInt ("trigt"));
			ok.SetActive(!ok.activeSelf);
			PlayerPrefs.SetInt ("trigt_time", 15);
		}
	}
}
