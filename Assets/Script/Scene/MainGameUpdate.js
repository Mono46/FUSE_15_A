// ----------------------------------------------------------------------
// メインゲーム画面制御
// ----------------------------------------------------------------------
#pragma strict

private var count : int = 30 + 1;
var textTime : GameObject = null;
var textTimeUp : GameObject = null;

private var isGameEnd : boolean = false;

// --------------------------------------------------
// 開始処理
// --------------------------------------------------
function Start () {
	DontDestroyOnLoad(textTime);
	
	textTime.GetComponent(TextMesh).text = count.ToString();
	textTimeUp.SetActiveRecursively(false);
	
	CountDown();
}

// --------------------------------------------------
// 更新処理
// --------------------------------------------------
function Update () {
	
}

// --------------------------------------------------
// シーン遷移
// --------------------------------------------------
function ChangeScene () {
	Application.LoadLevel("Result");
}

// --------------------------------------------------
// カウントダウン
// --------------------------------------------------
function CountDown () {
	count--;
	textTime.GetComponent(TextMesh).text = count.ToString();
	
	if (count <= 0) {
		TimeUp();
	}
	else {
		Invoke("CountDown", 1.0f);
	}
}

// --------------------------------------------------
// タイムアップ
// --------------------------------------------------
function TimeUp () {
	isGameEnd = true;
	textTimeUp.SetActiveRecursively(true);
	Invoke("ChangeScene", 2.0f);
}
