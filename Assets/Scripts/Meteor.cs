using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Meteor : MonoBehaviour {
	//Const 
	public const int MAXDIST = 100;

	//GameObjects
	Transform planet;

	//UI
	Text distT;
	Text stateT;

	//Int
	public int result = 0;
	public float dist = MAXDIST;
	public int state;
	int moveSpeed = 1;
	//int maxDist = 100;
	float minDist = 1.1f;

	[HideInInspector]
	public int paramA;
	[HideInInspector]
	public int paramB;
	[HideInInspector]
	public int paramResult;

	MeteorGenerator meGenerator;
	Meteor self;
	TextMesh textFunction;

	//String
	public string operation = "defineix funcio";




	void OnMouseDown(){
		Debug.Log ("Holaswqdqw");
		meGenerator.selectionUpdate (self);

	}



	// Use this for initialization
	void Start () {


		planet = GameObject.Find ("PlanetGameObject").transform;
		distT = GameObject.Find ("ActualDist").GetComponent<Text>();
		stateT = GameObject.Find ("State").GetComponent<Text>();


		meGenerator = GameObject.FindObjectOfType<MeteorGenerator>();

		self = this.transform.GetComponent<Meteor>();
		meGenerator.updateParams(self);
		Debug.Log("results "+ result);

		//textFunction.text = GetComponentInChildren<TextMesh>().text = paramA+" + "+paramB+" = ?";

		textFunction = GetComponentInChildren<TextMesh> ();
		textFunction.text = paramA+" + "+paramB+" = ?";
		//textFunction.text = GetComponentInChildren<TextMesh>().text = paramA+" + "+paramB+" = ?";



		//textFunction.transform.rotation = new Quaternion (this.transform.rotation.x * -1, this.transform.rotation.y * -1, this.transform.rotation.z * -1);




		
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(planet);

		textFunction.transform.rotation = Quaternion.identity;



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
			Destroy (gameObject);
		}


	
	}

}
