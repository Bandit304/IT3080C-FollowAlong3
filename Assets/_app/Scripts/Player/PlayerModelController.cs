using UnityEngine;

public class PlayerModelController : MonoBehaviour {
    public void OnEnable() {
        DelegateManager.deathEvent += OnDeath;
    }

    public void OnDisable() {
        DelegateManager.deathEvent -= OnDeath;
    }

    public void OnDeath() {
        // Delete player model on death
        Destroy(gameObject);
    }
}
