using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 300f;

    private Vector2 movement = Vector2.zero;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // ������ ����������� �����������
        movement = new Vector2(horizontalInput, verticalInput).normalized;

        // ���������� ������
        if (movement != Vector2.zero)
        {
            // ���������� ������
            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }
}
