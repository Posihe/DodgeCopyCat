using UnityEngine;

public class DayCycle : MonoBehaviour
{
    [Header("�Ϸ簡 �������� �ð�(��)")]
    public float dayDuration = 120f; // �⺻��: 120��(2��)

    private float rotationSpeed;

    void Start()
    {
        // �Ϸ� ���� 360�� ȸ���ؾ� �ϹǷ� �ʴ� ȸ�� �ӵ��� ���
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // �����Ӹ��� ȸ�� �ӵ��� ���� Directional Light�� ȸ��
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
