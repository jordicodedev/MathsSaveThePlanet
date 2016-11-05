using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Meteor : MonoBehaviour {
	//Const 
	public const int MAXDIST = 100;

	//GameObjects
	public Transform planet;

	//UI
	public Text distT;
	public Text stateT;

	//Int
	public int result = 0;
	public float dist = MAXDIST;
	public int state;
	int moveSpeed = 2;
	//int maxDist = 100;
	float minDist = 0.5f;

	int paramA = 2;
	int paramB = 0;
	int paramResult = 0;

	//String
	public string operation = "defineix funcio";




	void OnMouseDown(){
		Debug.Log ("Holaswqdqw");
	}

	// Use this for initialization
	void Start () {
		//stateT.text = state.ToString();
		GetComponentInChildren<TextMesh>().text = paramA+" + "+paramB+" = ?";

		
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(planet);



		if(Vector3.Distance(transform.position,planet.position) >= minDist){

			transform.position += transform.forward*moveSpeed*Time.deltaTime;
			dist = Vector3.Distance(transform.position,planet.position);
			distT.text = dist.ToString();



			if(Vector3.Distance(transform.position,planet.position) <= MAXDIST)
			{
				//Here Call any function U want Like Shoot at here or something
				//Destroy(gameObject);
				stateT.text = "x";

			} 


		}
		if(Vector3.Distance(transform.position,planet.position) <= minDist)
		{
			//Here Call any function U want Like Shoot at here or something
			//Destroy(gameObject);
			stateT.text = "Destroyed";
			gameObject.SetActive(false);
		}


	
	}

}
