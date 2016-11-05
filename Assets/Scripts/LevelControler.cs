using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelControler : MonoBehaviour {

    int lvl;

    float timerPlus = 160.30f;
    float timerMinus = 30f;
    float timerMultiplayer = 0.02f;
    float timerDivider = 0f;

    public Text bestTimeText;
    public Text operationText;

    // Use this for initialization
    void Start () {
        lvl = 1;
        bestTimeText.text = "Best Time: " + getMaxPunct();
        switch (lvl)
        {
            case 2:
                operationText.text = "Operation: -";
                break;
            case 3:
                operationText.text = "Operation: *";
                break;
            case 4:
                operationText.text = "Operation: /";
                break;
            case 1:
            default:
                operationText.text = "Operation: +";
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    float getMaxPunct() {
        switch (lvl) {
            case 2:
                return timerMinus;
            case 3:
                return timerMultiplayer;
            case 4:
                return timerDivider;
            case 1:
            default:
                return timerPlus;
        }
    }

    public void nextLevel() {
        lvl++;
        if (lvl == 5) lvl = 1;
        bestTimeText.text = "Best Time: " + getMaxPunct();
        switch (lvl)
        {
            case 2:
                operationText.text = "Operation: -";
                break;
            case 3:
                operationText.text = "Operation: *";
                break;
            case 4:
                operationText.text = "Operation: /";
                break;
            case 1:
            default:
                operationText.text = "Operation: +";
                break;
        }
    }
    public void previousLevel()
    {
        lvl--;
        if (lvl == 0) lvl = 4;
        bestTimeText.text = "Best Time: " + getMaxPunct();
        switch (lvl)
        {
            case 2:
                operationText.text = "Operation: -";
                break;
            case 3:
                operationText.text = "Operation: *";
                break;
            case 4:
                operationText.text = "Operation: /";
                break;
            case 1:
            default:
                operationText.text = "Operation: +";
                break;
        }
    }
    public void selectLevel() {
        GameObject.FindObjectOfType<MeteorGenerator>().lvl = lvl;
        gameObject.SetActive(false);
    }
}
