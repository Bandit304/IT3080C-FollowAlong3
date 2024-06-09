using UnityEngine;

public class InteractableExample : MonoBehaviour, IInteractable {

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Interact();
            Destroy(gameObject);
        }
    }

    public void Interact() {
        DelegateManager.scoreEvent?.Invoke(1);
    }
}