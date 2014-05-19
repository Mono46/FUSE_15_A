using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	TextMesh numberText;
	//public AudioClip soundSuccess = null;
	//public AudioClip soundFail = null;

	void Start() {

		numberText = GameObject.Find("number").GetComponent<TextMesh>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)) {
			if (isAnswer(0)) {
				onSuccess();
			} else {
				onFail();
			}
		} else if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
			if (isAnswer(1)) {
				onSuccess();
			} else {
				onFail();
			}
		} else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
			if (isAnswer(2)) {
				onSuccess();
			} else {
				onFail();
			}
		} else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
			if (isAnswer(3)) {
				onSuccess();
			} else {
				onFail();
			}
		} else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
			if (isAnswer(4)) {
				onSuccess();
			} else {
				onFail();
			}
		} else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {
			if (isAnswer(5)) {
				onSuccess();
			} else {
				onFail();
			}
		} else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) {
			if (isAnswer(6)) {
				onSuccess();
			} else {
				onFail();
			}
		} else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) {
			if (isAnswer(7)) {
				onSuccess();
			} else {
				onFail();
			}
		} else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) {
			if (isAnswer(8)) {
				onSuccess();
			} else {
				onFail();
			}
		} else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) {
			if (isAnswer(9)) {
				onSuccess();
			} else {
				onFail();
			}
		}
		
	}

	bool isAnswer(int num) {
		if (num.ToString() == this.numberText.text) {
			return true;
		} else {
			return false;
		}
	}

	void onSuccess() {
	 	var showNumber = GameObject.Find("number").GetComponent<ShowNumber>();
		showNumber.nextNumber();
		if (showNumber == null) {
			Debug.Log("success");
		}
		Animator windAnim = GameObject.Find("WindMilAnimation").GetComponent<Animator>();
		windAnim.SetBool("isTurn", true);

		Animator penAnim = GameObject.Find("PenguinAnimation").GetComponent<Animator>();
		penAnim.SetFloat("windSpeed", 5.0f);

		//AudioSource audioSuccess = gameObject.GetComponent <AudioSource>.PlayOneShot(soundSuccess);
	}

	void onFail() {
		Debug.Log("fail");
		var showNumber = GameObject.Find("number").GetComponent<ShowNumber>();
		showNumber.nextNumber();
		Animator windAnim = GameObject.Find("WindMilAnimation").GetComponent<Animator>();
		windAnim.SetBool("isTurn", false);

		Animator penAnim = GameObject.Find("PenguinAnimation").GetComponent<Animator>();
		penAnim.SetFloat("windSpeed", 0.0f);
		
		//AudioSource audioFail = gameObject.GetComponent <AudioSource>.PlayOneShot(soundFail);
	}

}
