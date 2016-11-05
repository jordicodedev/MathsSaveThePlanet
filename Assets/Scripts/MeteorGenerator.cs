using UnityEngine;
using System.Collections;

public class MeteorGenerator : MonoBehaviour {
	float timerMeteor = 1.0f;
    float countDown = 30.0f;
	public GameObject meteor;
	public Meteor selectedMeteor;
	int val1;
	int val2;
	int result;
    public float radius = 15f;

    public int lvl;
	// Use this for initialization
	void Start () {
		CreateMeteors ();
	}

	// Update is called once per frame
	void Update () {
		timerMeteor -= Time.deltaTime;

		if (timerMeteor < 0)
		{
			CreateMeteors();
			timerMeteor = 10.0f;
		}

        countDown -= Time.deltaTime;


	}

    private GUIStyle textSize = new GUIStyle();

    void OnGUI()
    {

        textSize.fontSize = 20;
        
        GUI.Label(new Rect(Screen.width/2-10, Screen.height/2 - (Screen.height/2)/2, 100, 20), countDown.ToString("F0"), textSize);
    }

    void CreateMeteors()
	{
		GameObject m;
		m = Instantiate(meteor);

        var angle = Random.Range(0f,1f) * Mathf.PI * 2;

        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        m.transform.position = new Vector3(x,y,0);
		getOperation(lvl);
		m.SetActive (true);

		
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
		m.paramB = val2;
	}
    public void selectionUpdate(Meteor m) {
        selectedMeteor = m;
    }

	public void comprovacioResultat(int respostaJugador){
		if (respostaJugador == selectedMeteor.result) {
			Destroy (selectedMeteor.gameObject);
			//Afegir temps
		}else{
			//incrementar velocitat
		}
	}
		
}