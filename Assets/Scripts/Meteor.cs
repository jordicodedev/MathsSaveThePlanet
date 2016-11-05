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
	public float moveSpeed = 0.2f;
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
	KeyBoardManager kbmanager;

	//String
	public string operation = "defineix funcio";




	void OnMouseDown(){

		Meteor[] meteorits = GameObject.FindObjectsOfType<Meteor>();
		foreach(Meteor meteorit in meteorits){
			meteorit.GetComponentInChildren<Renderer> ().material.color = Color.white;
		}
		gameObject.GetComponentInChildren<Renderer> ().material.color = Color.green;

		Debug.Log ("Meteor selected");
		meGenerator.selectionUpdate (self);

	}



	// Use this for initialization
	void Start () {

		moveSpeed = Random.Range(0.15f,0.4f);
		planet = GameObject.Find ("PlanetGameObject").transform;
		distT = GameObject.Find ("ActualDist").GetComponent<Text>();
		stateT = GameObject.Find ("State").GetComponent<Text>();
		//kbmanager = GameObject.Find ("InputKeyBoard");


		meGenerator = GameObject.FindObjectOfType<MeteorGenerator>();

		self = this.transform.GetComponent<Meteor>();
		meGenerator.updateParams(self);
		Debug.Log("results "+ result);

		//textFunction.text = GetComponentInChildren<TextMesh>().text = paramA+" + "+paramB+" = ?";

		textFunction = GetComponentInChildren<TextMesh> ();
		textFunction.text = paramA+" + "+paramB+" = "+result;
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
			stateT.text = "Destroyed";
            meGenerator.gameOver();
			Destroy (gameObject);

		}
	
	}

}
