using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {
	public Vector3 rotation = new Vector3(0, 80, 0);
	public int s = 0;

	// Use this for initialization

	void Start () {
		transform.GetChild(0).gameObject.SetActive(true);
		transform.GetChild(1).gameObject.SetActive(false);
		transform.GetChild(2).gameObject.SetActive(false);
		transform.GetChild(3).gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotation * Time.deltaTime, Space.World);
		switchPlanet ();
	
	}

	void switchPlanet(){
		switch(s){
		case 0:
			transform.GetChild(0).gameObject.SetActive(true);
			transform.GetChild(1).gameObject.SetActive(false);
			transform.GetChild(2).gameObject.SetActive(false);
			transform.GetChild(3).gameObject.SetActive(false);
			Debug.Log ("Loaded planet state 1");
			break;
		case 1:
			transform.GetChild(0).gameObject.SetActive(false);
			transform.GetChild(1).gameObject.SetActive(true);
			transform.GetChild(2).gameObject.SetActive(false);
			transform.GetChild(3).gameObject.SetActive(false);
			Debug.Log ("Loaded planet state 2");
			break;
		case 2:
			transform.GetChild(0).gameObject.SetActive(false);
			transform.GetChild(1).gameObject.SetActive(false);
			transform.GetChild(2).gameObject.SetActive(true);
			transform.GetChild(3).gameObject.SetActive(false);
			Debug.Log ("Loaded planet state 3");
			break;
		case 3:
			transform.GetChild(0).gameObject.SetActive(false);
			transform.GetChild(1).gameObject.SetActive(false);
			transform.GetChild(2).gameObject.SetActive(false);
			transform.GetChild(3).gameObject.SetActive(true);
			Debug.Log ("Loaded planet state 4");
			break;
		default:
			Debug.Log ("No planet");
			break;
		}
	}
}
