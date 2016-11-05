using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyBoardManager : MonoBehaviour {

    public Text answerText;
    public int ans;
	public bool submitValue;
	MeteorGenerator mg;

	// Use this for initialization
	void Start () {
        ans = 0;
        answerText.text = "0";
		submitValue = false;
		mg = GameObject.FindObjectOfType<MeteorGenerator> ();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void add(int num) {
        if (ans != 0) {
            ans *= 10;
        }
        ans += num;
        answerText.text = "" + ans;
    }
    public void delete() {
        if (ans != 0)
        {
            ans /= 10;
            answerText.text = "" + ans;
        }
    }
    public void sendAnswer()
    {
		
		Debug.Log("Enterr");
		mg.comprovacioResultat (ans);
		ans = 0;
		answerText.text = ""+ans;



        
    }
}
