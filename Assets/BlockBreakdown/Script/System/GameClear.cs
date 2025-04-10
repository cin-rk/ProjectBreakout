using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    // Transform
    Transform myTransform;
    // ScriptableObject
    [SerializeField]
    UIMessegeTable _uIMessegeTable;

    // ゲームクリア用のメッセージ
    TextMeshProUGUI _gameClearMessage;
    // ゲームクリアのフラグ
    bool isGameOver = false;

    void Start()
    {
        // Transformコンポーネントを呼び出し
        myTransform = transform;
        // テキストのコンポーネント呼び出し
        _gameClearMessage = GameObject.Find("SystemText").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // スコア用の得点計算
        Score.ScoreCalculation(myTransform.childCount);
        
        // 子供がいなくなったらゲームを停止する
        if (myTransform.childCount == 0)
        {
            if(_gameClearMessage != null)
            {
                // テキスト文の設定
                _gameClearMessage.text = _uIMessegeTable.GameClear;
                // 時間を停止
                Time.timeScale = 0f;
                // ゲームクリアのフラグを立てる
                isGameOver = true;

                // ゲームオーバかつSubmitボタンを押下時
                if (isGameOver && Input.GetButtonDown("Submit"))
                {
                    // 時間を再開
                    Time.timeScale = 1f;
                    // Stege1Sceneシーンをロードする
                    SceneManager.LoadScene("Stage1Scene");
                }
            } else
            {
                Debug.Log("SystemTextをCanvasに追加してください または Textの名称を確認してください");
            }
        }
    }
}
