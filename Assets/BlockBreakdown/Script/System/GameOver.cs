using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // ScriptableObject
    [SerializeField]
    UIMessegeTable _uIMessegeTable;

    // ゲームオーバ用のメッセージ
    TextMeshProUGUI _gameOverMessage;
    // ゲームオーバのフラグ
    bool isGameOver = false;

    void Start()
    {
        // テキストのコンポーネント呼び出し
        _gameOverMessage = GameObject.Find("SystemText").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // ゲームオーバかつSubmitボタンを押下時
        if (isGameOver && Input.GetButtonDown("Submit"))
        {
            // 時間を再開
            Time.timeScale = 1f;
            // Stege1Sceneシーンをロードする
            SceneManager.LoadScene("Stage1Scene");
        }
    }

    // 衝突時に呼ばれる
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // 時間を停止
            Time.timeScale = 0f;
            // テキストの表示(ゲームオーバー)
            _gameOverMessage.text = _uIMessegeTable.GameOver;
            // 当たったゲームオブジェクトを削除する
            Destroy(collision.gameObject);
            // ゲームオーバのフラグを立てる
            isGameOver = true;
        }
    }
}
