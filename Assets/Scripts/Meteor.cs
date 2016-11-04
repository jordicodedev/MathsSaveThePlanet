using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour {
	public Transform Planet;
	int MoveSpeed = 2;
	int MaxDist = 100;
	int MinDist = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Planet);

		if(Vector3.Distance(transform.position,Planet.position) >= MinDist){

			transform.position += transform.forward*MoveSpeed*Time.deltaTime;



			if(Vector3.Distance(transform.position,Planet.position) <= MaxDist)
			{
				//Here Call any function U want Like Shoot at here or something
			} 

		}
	
	}
}
