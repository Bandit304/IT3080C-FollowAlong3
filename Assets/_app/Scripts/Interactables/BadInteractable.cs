using UnityEngine;

public class BadInteractable : MonoBehaviour, IInteractable {
    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Interact();
            Destroy(gameObject);
        }
    }

    public void Interact() {
        DelegateManager.deathEvent?.Invoke();
    }
}
