﻿// --------------------------------------------------
// リザルト画面制御
// --------------------------------------------------
#pragma strict

private var score : GameObject = null;	// スコア管理オブジェクト

// --------------------------------------------------
// 開始処理
// --------------------------------------------------
function Start () {
	score = GameObject.Find("3DTextTime");
	if (score != null) {
		score.SetActiveRecursively(false);
	}
}

// --------------------------------------------------
// 更新処理
// --------------------------------------------------
function Update () {
	// キー入力判定処理
	InputKey();
}

// --------------------------------------------------
// 削除処理
// --------------------------------------------------
function OnDestroy () {
	Debug.Log(score);
	if (score != null) {
		Destroy(score);
		Debug.Log("score Destroy.");
	}
}

// --------------------------------------------------
// キー入力判定
// --------------------------------------------------
function InputKey() {
	// スペースキー
	if (Input.GetButtonDown("Jump")) {
		// シーン遷移
		ChangeScene();
	}
}

// --------------------------------------------------
// シーン遷移
// --------------------------------------------------
function ChangeScene () {
	Application.LoadLevel("Title");
}
