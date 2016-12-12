using UnityEngine;
using System.Collections;

public class ProjectsPick : MonoBehaviour {
	public GameObject p1;
	public GameObject ok;
	private int t,num;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("trigpr", -1);
		PlayerPrefs.SetInt ("trigpr_time", 0);
		ok.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("trigpr_time") > 0) {
			p1.transform.position=p1.transform.position+new Vector3(PlayerPrefs.GetInt ("trigpr")*1*0.8f,0,0);
			PlayerPrefs.SetInt ("trigpr_time", PlayerPrefs.GetInt ("trigpr_time")-1);
		}
	}
	void OnMouseDown()
	{
		if ((PlayerPrefs.GetInt ("trigpr_time") == 0)&&(PlayerPrefs.GetInt ("trigst")== -1)&&(PlayerPrefs.GetInt ("trigt")== -1)) {
			PlayerPrefs.SetInt ("trigpr", -PlayerPrefs.GetInt ("trigpr"));
			ok.SetActive(!ok.activeSelf);
			PlayerPrefs.SetInt ("trigpr_time", 15);
		}
	}
}