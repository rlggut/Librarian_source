using UnityEngine;
using System.Collections;

public class Tasks : MonoBehaviour {
	public int num_name,look_name;
	public int price;
	public int cash_need,bibl_need, pr_need, prog_need;
	public int ch, bi, pr, prog;
	public GameObject sf;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		pr = PlayerPrefs.GetInt (num_name.ToString () + "pr");
		prog = PlayerPrefs.GetInt (num_name.ToString () + "prog");
		bi = PlayerPrefs.GetInt (num_name.ToString () + "bibl");
		ch = PlayerPrefs.GetInt (num_name.ToString () + "cash");

		if((PlayerPrefs.GetInt ("look"+look_name.ToString())== 0)&&(PlayerPrefs.GetInt (num_name.ToString ())== 1)) sf.SetActive(false);

		if((PlayerPrefs.GetInt (num_name.ToString ())==0)&&(PlayerPrefs.GetInt(num_name.ToString()+"cash")==cash_need)&&(PlayerPrefs.GetInt(num_name.ToString()+"bibl")==bibl_need)
		   &&(PlayerPrefs.GetInt(num_name.ToString()+"pr")==pr_need)&&(PlayerPrefs.GetInt(num_name.ToString()+"prog")==prog_need))
		{
			PlayerPrefs.SetInt ("money", PlayerPrefs.GetInt("money")+price);
			PlayerPrefs.SetInt (num_name.ToString (), 1);
		}
	}
}