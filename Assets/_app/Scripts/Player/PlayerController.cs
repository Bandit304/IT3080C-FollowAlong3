using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // ##### Public Components #####
    [Header("Movement Components")]
    public float movementSpeed;

    // ##### Local variables #####
    private Vector2 movement;

    // ##### Unity Lifecycle Methods #####

    public void OnEnable() {
        DelegateManager.deathEvent += OnDeath;
    }

    public void OnDisable() {
        DelegateManager.deathEvent -= OnDeath;
    }

    public void Update() {
        transform.Translate(new Vector3(movement.x, 0, movement.y) * movementSpeed * Time.deltaTime);

        // Invoke string event if space was pressed
        if (Input.GetKeyDown(KeyCode.Space))
            DelegateManager.stringEvent?.Invoke("Space was pressed");
    }

    // ##### Custom Methods #####

    public void PlayerMovement(InputAction.CallbackContext context) {
        movement = context.ReadValue<Vector2>();
    }

    public void OnDeath() {
        Destroy(this);
    }
}
