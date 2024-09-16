using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 300f;

    private Vector2 movement = Vector2.zero;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Вектор направления перемещения
        movement = new Vector2(horizontalInput, verticalInput).normalized;

        // Перемещаем игрока
        if (movement != Vector2.zero)
        {
            // Перемещаем игрока
            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }
}
