using UnityEngine;

[CreateAssetMenu(fileName = "UIMessege", menuName = "Scriptable Objects/UIMessegeTable")]
public class UIMessegeTable : ScriptableObject
{
    [SerializeField, CustomLabel("ゲームクリアのメッセージ"), TextArea] string gameClear;
    public string GameClear{ get { return gameClear; } private set { gameClear = value; } }

    [SerializeField, CustomLabel("ゲームオーバのメッセージ"), TextArea] string gameOver;
    public string GameOver{ get { return gameOver; } private set { gameOver = value; } }

    [SerializeField, CustomLabel("ゲームスタートのメッセージ"), TextArea] string gameStart;
    public string GameStart{ get { return gameStart; } private set { gameStart = value; } }

    [SerializeField, CustomLabel("ゲームのルール"), TextArea] string gameRule;
    public string GameRule{ get { return gameRule; } private set { gameRule = value; } }

    [SerializeField, CustomLabel("スタートUIテキスト"), TextArea] string startUIText;
    public string StartUIText{ get { return startUIText; } private set { startUIText = value; } }

    [SerializeField, CustomLabel("スタートUIボタン"), TextArea] string startUIButton;
    public string StartUIButton{ get { return startUIButton; } private set { startUIButton = value; } }
}
