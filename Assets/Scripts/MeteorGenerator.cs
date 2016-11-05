using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MeteorGenerator : MonoBehaviour {
	float timerMeteor = 1.0f;
    float countDown = 30.0f;
    float finnishingTime = 0f;
	public GameObject meteor;
	public Meteor selectedMeteor;
	int val1;
	int val2;
	int result;
    public float radius = 15f;
	Text timerT;

    public GameObject gameOverObject;
    public GameObject keyBoardObject;

    Planet planeta;

    public int lvl;
	// Use this for initialization
	void Start () {
		CreateMeteors ();
		timerT = GameObject.Find ("Timer").GetComponent<Text>();
        planeta = GameObject.FindObjectOfType<Planet>();
	}

	// Update is called once per frame
	void Update () {
		timerMeteor -= Time.deltaTime;
		timerT.text = countDown.ToString ("F0");
		if (timerMeteor < 0)
		{
            if (countDown > 0){
                CreateMeteors();
            }			
			timerMeteor = 10.0f;
		}

       
        if (countDown <= 0){
            Debug.Log("temps!");
            gameOver();
            countDown = 0;
        }
        else {
            countDown -= Time.deltaTime;
            finnishingTime += Time.deltaTime;
        }
        if (finnishingTime < 10) {
            planeta.s = 0;
        } else if (finnishingTime < 20)
        {
            planeta.s = 1;
        }
        else if (finnishingTime < 30)
        {
            planeta.s = 2;
        }
        else 
        {
            planeta.s = 3;
        }


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
            countDown += 5;
		}else{
			selectedMeteor.moveSpeed += 0.3f; 
		}
	}

    public void gameOver(){
        countDown = 0;
        timerT.text = "" + finnishingTime.ToString("F0") + " seconds";
        keyBoardObject.SetActive(false);
        gameOverObject.SetActive(true);
    }

    public void reset(){
        finnishingTime = 0f;
        Meteor[] meteorits = GameObject.FindObjectsOfType<Meteor>();
        foreach (Meteor meteorit in meteorits)
        {
            Destroy(meteorit.gameObject);
        }
        keyBoardObject.SetActive(true);
        gameOverObject.SetActive(false);
        countDown = 30;
    }

}