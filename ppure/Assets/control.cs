using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public GameObject c1,c2,c3,box1,m1,m2,m3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startbut()
	{
		StartCoroutine (count1 ());

	}

	IEnumerator count1(){

		c1.SetActive (true);
		yield return new WaitForSeconds (1);
		c1.SetActive (false);

		StartCoroutine (count2 ());
	}

	IEnumerator count2(){
		
		c2.SetActive (true);
		yield return new WaitForSeconds (1);
		c2.SetActive (false);
		StartCoroutine (count3 ());
	}
	IEnumerator count3(){
		
		c3.SetActive (true);
		yield return new WaitForSeconds (1);
		c3.SetActive (false);
		StartCoroutine (box ());
	}	

	IEnumerator box(){
		
		box1.SetActive (true);
		yield return new WaitForSeconds (3);
		box1.SetActive (false);
		StartCoroutine (mario1 ());
	}	


	IEnumerator mario1(){
		
		m1.SetActive (true);
		yield return new WaitForSeconds (2);
		m1.SetActive (false);
		StartCoroutine (mario2 ());
	}	


	IEnumerator mario2(){
		
		m2.SetActive (true);
		yield return new WaitForSeconds (2);
		m2.SetActive (false);
		StartCoroutine (mario3 ());
	}	

	IEnumerator mario3(){
		
		m3.SetActive (true);
		yield return new WaitForSeconds (2);
		m3.SetActive (false);
		
	}	
}
