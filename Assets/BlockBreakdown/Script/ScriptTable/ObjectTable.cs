using UnityEngine;

[CreateAssetMenu(fileName = "ObjectTable", menuName = "Scriptable Objects/ObjectTable")]
public class ObjectTable : ScriptableObject
{
    [SerializeField, Range(0, 20), CustomLabel("ボールの速度")] float ballspeed;
    public float Ballspeed { get { return ballspeed; } private set { ballspeed = value; } }

    [SerializeField, Range(0, 20), CustomLabel("プレイヤーの速度")] float playerspeed;
    public float Playerspeed { get { return playerspeed; } private set { playerspeed = value; } }

    [SerializeField, Range(0, 20), CustomLabel("ボールの最大速度")] float maxSpeed;
    public float MaxSpeed { get { return maxSpeed; } private set { maxSpeed = value; } }

    [SerializeField, Range(0, 20), CustomLabel("ボールの最小速度")] float minSpeed;
    public float MinSpeed { get { return minSpeed; } private set { minSpeed = value; } }
}
