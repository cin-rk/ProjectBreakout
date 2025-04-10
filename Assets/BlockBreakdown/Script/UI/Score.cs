using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // スコア用のメッセージ
    TextMeshProUGUI _scoreMessage;
    // スコア値
    static int _scoreValue;

    void Start()
    {
        // テキストのコンポーネント呼び出し
        _scoreMessage = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        _scoreMessage.SetText("残ブロック：" + _scoreValue);
    }

    public static void ScoreCalculation(int value)
    {
        _scoreValue = value;
    }
}
