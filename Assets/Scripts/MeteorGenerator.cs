﻿using UnityEngine;
using System.Collections;
public class MeteorGenerator : MonoBehaviour {
	float timerMeteor = 5.0f;
	public GameObject meteor;
	Meteor meteorObject;
	int val1;
	int val2;
	int result;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timerMeteor -= Time.deltaTime;
		CreateMeteors();
		if (timerMeteor < 0)
		{
			CreateMeteors();
			timerMeteor = 10.0f;
		}
	}    
	void CreateMeteors()
	{
		GameObject m;
		m = Instantiate(meteor);
		m.transform.position = new Vector3(0,0,0);
		getOperation(1);

		//op = METEMATICA.GEToperacio(lvl);
		//m.GetComponent<Meteor>().reciveOperation(op);
	}
	void getOperation(int level)
	{
		switch (level)
		{
		case 1:
			sum();
			Debug.Log("Sum");
			break;
		case 2:
			//deduct();
			Debug.Log("resta");
			break;
		case 3:
			//multiply();
			Debug.Log("multiplicacio");
			break;
		case 4:
			//divide();
			Debug.Log("divisio");
			break;
		default:
			Debug.Log("nothing, only 1");
			break;
		}
	}
	void sum()
	{
		val1 = Random.Range(1, 20);
		val2 = Random.Range(1, 20);
		result = val1 + val2;
		//Debug.Log(val1);
		//Debug.Log(val2);
		//Debug.Log(val1 + val2);
	}
	void deduct()
	{
		result = 0;
		val1 = Random.Range(1, 20);
		val2 = Random.Range(1, 20);
		if (val1 >= val2)
		{
			result = val1 - val2;
		}
		else
		{
			result = val2 - val1;
		}
	}
	void multiply()
	{
	}
	void divide()
	{
	}
	public void updateParams(Meteor m) {
		m.result = result;
		m.paramA = val1;
	}
}