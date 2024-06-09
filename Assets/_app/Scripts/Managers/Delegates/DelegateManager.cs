using UnityEngine;
using UnityEngine.Events;

public class DelegateManager : MonoBehaviour {
    public delegate void ScoreDelegate(int n);
    public delegate void DeathDelegate();
    public delegate void StringEvent(string s);
    public static ScoreDelegate scoreEvent;
    public static DeathDelegate deathEvent;
    public static StringEvent stringEvent;

    public static UnityEvent OnEndGame;

    public void Update() {
        OnEndGame?.Invoke();
    }
}
