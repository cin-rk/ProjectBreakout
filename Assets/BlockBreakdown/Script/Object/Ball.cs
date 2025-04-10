using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // 速さ
    float _speed;
    // 最大値
    float _maxSpeed;
    // 最小値
    float _minSpeed;
    // 最初だけ操作するフラグ
    bool _startFlag;

    // ScriptableObject
    [SerializeField]
    ObjectTable _objectTable;
    // Rigidbodyの定数
    Rigidbody _myRigidbody;
    // Transformコンポーネントの定数
    Transform _myTransform;
    // メッセージ
    TextMeshProUGUI _message;

    void Start()
    {
        Initialization();
        // 時間を停止
        Time.timeScale = 0f;
        // プレイヤーの上に乗せる
        _myTransform.position = new Vector3(0f, -6.5f, 0f);
    }

    void Update()
    {
        Move();
    }

    // 衝突したときに呼ばれる
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (_myTransform != null)
            {
                // 当たったオブジェクトの位置を取得
                var playerPos = collision.transform.position;
                // ボールの位置を取得
                var ballPos = _myTransform.position;
                // プレイヤーから見たボールの方向を計算
                var direction = (ballPos - playerPos).normalized;
                // 現在の速さを取得
                var nowSpeed = _myRigidbody.linearVelocity.magnitude;
                // 速度を変更
                _myRigidbody.linearVelocity = direction * nowSpeed;
            }
        }
    }

    // 定数の初期化および取得
    void Initialization()
    {
        // Rigidbodyにアクセスして変数に保持しておく
        _myRigidbody = GetComponent<Rigidbody>();
        // Transformコンポーネントを取得
        _myTransform = transform;
        // テキストのコンポーネント呼び出し
        _message = GameObject.Find("SystemText").GetComponent<TextMeshProUGUI>();

        // 値代入
        _speed = _objectTable.Ballspeed;
        _maxSpeed = _objectTable.MaxSpeed;
        _minSpeed = _objectTable.MinSpeed;
        _startFlag = true;
    }

    // 移動処理
    void Move()
    {
        if (_myRigidbody != null)
        {
            // マウスの右クリックでボールを動かす
            if (_startFlag && Input.GetMouseButtonDown(0))
            {
                if (_message != null)
                {
                    // 時間を再開
                    Time.timeScale = 1f;
                    _message.text = "";
                    _myRigidbody.linearVelocity = new Vector3(0f, _speed, 0f);
                    _startFlag = false;
                } else
                {
                    Debug.Log("SystemTextをCanvasに追加してください または Textの名称を確認してください");
                }
            }

            if (_speed == 0.0f && _maxSpeed == 0.0f && _minSpeed == 0.0f)
            {
                // 現在の速度を取得
                var velocity = _myRigidbody.linearVelocity;
                // 速度の範囲を設定
                var clampedSpeed = Mathf.Clamp(velocity.magnitude, _minSpeed, _maxSpeed);
                // 速度を変更
                _myRigidbody.linearVelocity = velocity.normalized * clampedSpeed;
            }
        } else
        {
            Debug.Log("ボールのオブジェクトにRigidbodyを設定してください");
        }
    }
}
