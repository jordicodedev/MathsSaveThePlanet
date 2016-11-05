using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

    public void changeTo(int escena) {
        Application.LoadLevel(escena);
    }
}
