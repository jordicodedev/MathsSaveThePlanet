using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyBoardManager : MonoBehaviour {

    public Text answerText;
    int ans;

	// Use this for initialization
	void Start () {
        ans = 0;
        answerText.text = "0";
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
        
    }
}
