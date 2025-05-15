using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private CharacterController controller;
    public Transform cameraTransform;  // נוסיף את המצלמה כאן

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // ניקח את כיוון התנועה לפי המצלמה — אבל בלי תזוזה בציר Y
        Vector3 forward = new Vector3(cameraTransform.forward.x, 0f, cameraTransform.forward.z).normalized;
        Vector3 right = new Vector3(cameraTransform.right.x, 0f, cameraTransform.right.z).normalized;

        Vector3 direction = right * moveX + forward * moveZ;

        controller.Move(direction * speed * Time.deltaTime);
    }

}
