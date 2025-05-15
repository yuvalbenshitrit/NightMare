using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float lifespan = 5f; // ���� ����� (��� ���� ����� ���� ��� ��)

    private void Start()
    {
        // ����� ����� ���� 'lifespan' �����, �� ��� �� ��� �����
        Destroy(gameObject, lifespan);
    }

    void OnTriggerEnter(Collider other)
    {
        // �� ����� ���� ������
        if (other.CompareTag("Zombie"))
        {
            // ������, ����� �� ������
            Destroy(other.gameObject); // ����� ������

            // ������ �� ����� ����
            Destroy(gameObject);       // ����� �����
        }
    }
}
