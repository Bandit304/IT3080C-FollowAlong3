using UnityEngine;

public class ScoreManager : MonoBehaviour {
    public int score;

    private void OnEnable() {
        DelegateManager.scoreEvent += OnScore;
        DelegateManager.deathEvent += OnDeath;
        DelegateManager.stringEvent += OnString;
    }

    private void OnDisable() {
        DelegateManager.scoreEvent -= OnScore;
        DelegateManager.deathEvent -= OnDeath;
        DelegateManager.stringEvent -= OnString;
    }

    private void OnScore(int n) {
        score += n;
        Debug.Log($"Score: {score}");
    }

    private void OnDeath() {
        Debug.Log("Death!");
        Debug.Log($"Final score: {score}");
        Destroy(this.gameObject);
    }

    private void OnString(string s) {
        Debug.Log($"String: {s}");
    }
}
