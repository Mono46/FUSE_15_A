using UnityEngine;
using System.Collections;
public class ShowNumber : MonoBehaviour {
	// Use this for initialization
	void Start () {
		int ver;
		ver = Random.Range (0, 9);
		var textObject = gameObject.GetComponent<TextMesh>();
		textObject.text = ver.ToString ();
	}
	// Update is called once per frame
	void Update () {
	}

	public void nextNumber() {
		Debug.Log ("next");
		gameObject.GetComponent<TextMesh>().text = Random.Range (0, 9).ToString();

	}
}