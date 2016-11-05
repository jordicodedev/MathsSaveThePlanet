using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	public AudioClip boto;
	public AudioSource altaveu;

    public void changeTo(int escena) {
        Application.LoadLevel(escena);
		altaveu.clip = boto;
		altaveu.Play ();
    }
}
