using UnityEngine;

public class Player : MonoBehaviour
{
    // プレイヤーの移動の速さ
    public float _speed = 10f;

    // ScriptableObject
    public ObjectTable _objectTable;
    // Rigidbodyの定数
    Rigidbody _myRigidbody;

    void Start()
    {
        Initialization();
    }

    void Update()
    {
        Move();
    }

    // 定数の初期化および取得
    void Initialization()
    {
        // Rigidbodyにアクセスして変数に保持
        _myRigidbody = GetComponent<Rigidbody>();

        // 値代入
        _speed = _objectTable.Playerspeed;
    }

    // 移動処理
    void Move()
    {
        // 左右のキー入力により速度を変更する
        _myRigidbody.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * _speed, 0f, 0f);
    }
}
