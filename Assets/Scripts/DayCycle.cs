using UnityEngine;

public class DayCycle : MonoBehaviour
{
    [Header("하루가 지나가는 시간(초)")]
    public float dayDuration = 120f; // 기본값: 120초(2분)

    private float rotationSpeed;

    void Start()
    {
        // 하루 동안 360도 회전해야 하므로 초당 회전 속도를 계산
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // 프레임마다 회전 속도에 따라 Directional Light를 회전
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
