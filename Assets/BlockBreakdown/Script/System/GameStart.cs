using TMPro;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // ScriptableObject
    [SerializeField]
    UIMessegeTable _uIMessegeTable;

    // ゲームオーバ用のメッセージ
    TextMeshProUGUI _gameStartMessage;

    void Start()
    {
        // テキストのコンポーネント呼び出し
        _gameStartMessage = GetComponent<TextMeshProUGUI>();
        // テキスト文の設定
        _gameStartMessage.text = _uIMessegeTable.GameStart;
    }
}
