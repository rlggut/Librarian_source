using UnityEngine;
using System.Collections;

public class Needs : MonoBehaviour {

	public int num_name;
	public int typ,max,t,tp;
	public GameObject ok1,ok2,ok3,ok4,ok5,ok6;
	// Use this for initialization

	void Start () {
	}
	// Update is called once per frame
	void Update () {
	
		ok1.SetActive (false); ok2.SetActive (false); ok3.SetActive (false); ok4.SetActive (false);
		ok5.SetActive (false); ok6.SetActive (false);
		
		if(typ==1) tp=PlayerPrefs.GetInt(num_name.ToString()+"pr");
		if(typ==2) tp=PlayerPrefs.GetInt(num_name.ToString()+"prog");
		if(typ==3) tp=PlayerPrefs.GetInt(num_name.ToString()+"bibl");
		if(typ==4) tp=PlayerPrefs.GetInt(num_name.ToString()+"cash");
		
		if(tp>=1) ok1.SetActive(true);
		if(tp>=2) ok2.SetActive(true);
		if(tp>=3) ok3.SetActive(true);
		if(tp>=4) ok4.SetActive(true);
		if(tp>=5) ok5.SetActive(true);
		if(tp>=6) ok6.SetActive(true);
	}

	void OnMouseDown()
	{
		if(typ==1) t=PlayerPrefs.GetInt(num_name.ToString()+"pr");
		if(typ==2) t=PlayerPrefs.GetInt(num_name.ToString()+"prog");
		if(typ==3) t=PlayerPrefs.GetInt(num_name.ToString()+"bibl");
		if(typ==4) t=PlayerPrefs.GetInt(num_name.ToString()+"cash");


		if((PlayerPrefs.GetInt ("PlayerWork1")==0)&&(PlayerPrefs.GetInt ("Player1")==typ)&&(max>t))
		{
			t++;
			PlayerPrefs.SetInt ("PlayerWork1",1);
			if(typ==1) PlayerPrefs.SetInt(num_name.ToString()+"pr",t);
			if(typ==2) PlayerPrefs.SetInt(num_name.ToString()+"prog",t);
			if(typ==3) PlayerPrefs.SetInt(num_name.ToString()+"bibl",t);
			if(typ==4) PlayerPrefs.SetInt(num_name.ToString()+"cash",t);
		}
		if((PlayerPrefs.GetInt ("PlayerWork2")==0)&&(PlayerPrefs.GetInt ("Player2")==typ)&&(max>t))
		{
			t++;
			PlayerPrefs.SetInt ("PlayerWork2",1);
			if(typ==1) PlayerPrefs.SetInt(num_name.ToString()+"pr",t);
			if(typ==2) PlayerPrefs.SetInt(num_name.ToString()+"prog",t);
			if(typ==3) PlayerPrefs.SetInt(num_name.ToString()+"bibl",t);
			if(typ==4) PlayerPrefs.SetInt(num_name.ToString()+"cash",t);
		}
		if((PlayerPrefs.GetInt ("PlayerWork3")==0)&&(PlayerPrefs.GetInt ("Player3")==typ)&&(max>t))
		{
			t++;
			PlayerPrefs.SetInt ("PlayerWork3",1);
			if(typ==1) PlayerPrefs.SetInt(num_name.ToString()+"pr",t);
			if(typ==2) PlayerPrefs.SetInt(num_name.ToString()+"prog",t);
			if(typ==3) PlayerPrefs.SetInt(num_name.ToString()+"bibl",t);
			if(typ==4) PlayerPrefs.SetInt(num_name.ToString()+"cash",t);
		}
		if((PlayerPrefs.GetInt ("PlayerWork4")==0)&&(PlayerPrefs.GetInt ("Player4")==typ)&&(max>t))
		{
			t++;
			PlayerPrefs.SetInt ("PlayerWork4",1);
			if(typ==1) PlayerPrefs.SetInt(num_name.ToString()+"pr",t);
			if(typ==2) PlayerPrefs.SetInt(num_name.ToString()+"prog",t);
			if(typ==3) PlayerPrefs.SetInt(num_name.ToString()+"bibl",t);
			if(typ==4) PlayerPrefs.SetInt(num_name.ToString()+"cash",t);
		}
		if((PlayerPrefs.GetInt ("PlayerWork5")==0)&&(PlayerPrefs.GetInt ("Player5")==typ)&&(max>t))
		{
			t++;
			PlayerPrefs.SetInt ("PlayerWork5",1);
			if(typ==1) PlayerPrefs.SetInt(num_name.ToString()+"pr",t);
			if(typ==2) PlayerPrefs.SetInt(num_name.ToString()+"prog",t);
			if(typ==3) PlayerPrefs.SetInt(num_name.ToString()+"bibl",t);
			if(typ==4) PlayerPrefs.SetInt(num_name.ToString()+"cash",t);
		}
		if((PlayerPrefs.GetInt ("PlayerWork6")==0)&&(PlayerPrefs.GetInt ("Player6")==typ)&&(max>t))
		{
			t++;
			PlayerPrefs.SetInt ("PlayerWork6",1);
			if(typ==1) PlayerPrefs.SetInt(num_name.ToString()+"pr",t);
			if(typ==2) PlayerPrefs.SetInt(num_name.ToString()+"prog",t);
			if(typ==3) PlayerPrefs.SetInt(num_name.ToString()+"bibl",t);
			if(typ==4) PlayerPrefs.SetInt(num_name.ToString()+"cash",t);
		}
	}
}