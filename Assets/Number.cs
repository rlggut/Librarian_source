using UnityEngine;
using System.Collections;

public class Number : MonoBehaviour {

	public string nam;
	public int dec;
	private int i,n;
	public GameObject p0,p1,p2,p3,p4,p5,p6,p7,p8,p9;
	// Use this for initialization
	void Start () {
	
	}
	void nil()
	{
		p0.SetActive(false);p1.SetActive(false);p2.SetActive(false);p3.SetActive(false);p4.SetActive(false);p5.SetActive(false);
		p6.SetActive(false);p7.SetActive(false);p8.SetActive(false);p9.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
		n = PlayerPrefs.GetInt (nam);
		nil ();
		for (i=0; i<dec; i++)
			n = (n - n % 10) / 10;
		n = n % 10;
		if(n==0) p0.SetActive(true);
		if(n==1) p1.SetActive(true);
		if(n==2) p2.SetActive(true);
		if(n==3) p3.SetActive(true);
		if(n==4) p4.SetActive(true);
		if(n==5) p5.SetActive(true);
		if(n==6) p6.SetActive(true);
		if(n==7) p7.SetActive(true);
		if(n==8) p8.SetActive(true);
		if(n==9) p9.SetActive(true);
	}
}