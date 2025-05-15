using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;  // ���� �� ����� (Player)

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; // �� �� ����� ����� �� ����
    }

    void Update()
    {
        // ����� �� �����
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // ����� ������ ����� ����� (��� X)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);  // ����� ������ �� ��� �-X

        // ����� ����� ����� ������ (��� Y)
        playerBody.Rotate(Vector3.up * mouseX);  // ����� �����
    }
}
