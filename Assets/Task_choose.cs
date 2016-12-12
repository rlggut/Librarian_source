using UnityEngine;
using System.Collections;

public class Task_choose : MonoBehaviour {

	public int start;
	public GameObject t1,t2,t3,t4,t5,t6;
	private int i;
	// Use this for initialization
	void Start () {
		t1.SetActive (false);t2.SetActive (false);t3.SetActive (false);t4.SetActive (false);t5.SetActive (false);t6.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		i = start;
		while (i<(start+6)) {
			if(PlayerPrefs.GetInt(i.ToString())==0)
			{
				if(i==start) t1.SetActive(true);
				if(i==(start+1)) t2.SetActive(true);
				if(i==(start+2)) t3.SetActive(true);
				if(i==(start+3)) t4.SetActive(true);
				if(i==(start+4)) t5.SetActive(true);
				if(i==(start+5)) t6.SetActive(true);
				break;
			}
			i++;
		}
	}
}