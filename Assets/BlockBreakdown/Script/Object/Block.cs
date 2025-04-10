using UnityEngine;

public class Block : MonoBehaviour
{
    // 何かとぶつかった時に呼ばれるビルトインメソッド
    void OnCollisionEnter(Collision collision)
    {
        // ボール反射調整
        if (collision.gameObject.CompareTag("Ball"))
        {
            var ballRigidbody = collision.rigidbody;

            if (ballRigidbody != null)
            {
                var contactPoint = collision.GetContact(0);

                ballRigidbody.linearVelocity = Vector3.Reflect(collision.relativeVelocity, contactPoint.normal);
            } else
            {
                Debug.Log("BallタグオブジェクトにRigidbodyを設定してください");
            }

            // ゲームオブジェクトを削除するメソッド
            Destroy(gameObject);
        }
    }
}
