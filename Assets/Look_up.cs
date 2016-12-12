using UnityEngine;
using System.Collections;

public class Look_up : MonoBehaviour {
	public GameObject block;
	public Vector3 set;
	public int nam;
	private int t,num;
	private Vector3 offset;
	private bool fl;
	// Use this for initialization
	void Start () {
		fl = false;
		block.SetActive (false);
		t = 0;
		num = -1;
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!fl) PlayerPrefs.SetInt ("look"+nam.ToString(), 0);
		else PlayerPrefs.SetInt ("look"+nam.ToString(), 1);

		if((num==-1)&&(t==0)) offset = transform.position;
		if (t > 0) {
			t--;
			transform.position=new Vector3(transform.position.x+num*((set.x-offset.x)/10),transform.position.y+num*((set.y-offset.y)/10),
			                               transform.position.z+num*((set.z-offset.z)/10));
		}
	
	}
	void OnMouseDown()
	{
		if (t == 0) {
			t=10;
			fl=!fl;
			block.SetActive(fl);
			num=-num;

		}
	}
}