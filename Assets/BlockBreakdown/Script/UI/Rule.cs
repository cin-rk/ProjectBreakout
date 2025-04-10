using TMPro;
using UnityEngine;

public class Rule : MonoBehaviour
{
    [SerializeField]
    UIMessegeTable _uIMessegeTable;

    // ゲームルール用のメッセージ
    TextMeshProUGUI _gameRuleMessage;

    void Start()
    {
        _gameRuleMessage = GameObject.Find("Rule").GetComponent<TextMeshProUGUI>();

        _gameRuleMessage.text = _uIMessegeTable.GameRule;
    }
}
