using UnityEngine;
using System.Collections;

public class MeteorGenerator : MonoBehaviour {

    float timerMeteor = 5.0f;
    public GameObject meteor;
    
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        timerMeteor -= Time.deltaTime;

        if (timerMeteor < 0)
        {
            CreateMeteors();
            timerMeteor = 5.0f;
        }

    }    

    void CreateMeteors()
    {

        GameObject m;
        m = Instantiate(meteor);
        m.transform.position = new Vector3(0,0,0);
        

        //op = METEMATICA.GEToperacio(lvl);
        //m.GetComponent<Meteor>().reciveOperation(op);
    }


    public string getOperation(int level)
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

        return "";
    }

    public Operation sum()
    {

        int val1 = Random.Range(1, 20);
        int val2 = Random.Range(1, 20);

        operation.result = val1 + val2;
        operation.val1 = val1;
        operation.val2 = val2;

        return operation;
    }

    void deduct()
    {
        int result = 0;
        int val1 = Random.Range(1, 20);
        int val2 = Random.Range(1, 20);

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

}
