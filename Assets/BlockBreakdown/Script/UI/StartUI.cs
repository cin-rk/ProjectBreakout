using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour
{
    // ScriptableObject
    [SerializeField]
    UIMessegeTable _uIMessegeTable;

    // テキスト用のメッセージ
    TextMeshProUGUI _startTextMessage;

    // ボタン用のテキスト
    TextMeshProUGUI _startButtonText;

    void Start()
    {
        // テキストのコンポーネント呼び出し
        _startTextMessage = GameObject.Find("SartText").GetComponent<TextMeshProUGUI>();
        _startButtonText = GameObject.Find("StartButton").GetComponent<TextMeshProUGUI>();

        // テキスト設定
        _startTextMessage.text = _uIMessegeTable.StartUIText;
        _startButtonText.text = _uIMessegeTable.StartUIButton;
    }

    
    public void Scene()
    {
        // Stege1Sceneシーンをロードする
        SceneManager.LoadScene("Stage1Scene");
    }
}
