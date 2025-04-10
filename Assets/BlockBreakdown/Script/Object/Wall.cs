using UnityEngine;

public class Wall : MonoBehaviour
{
    // 衝突したときに呼ばれる
    void OnCollisionEnter(Collision collision)
    {
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
        }
    }
}
