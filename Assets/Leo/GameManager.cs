using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] UnityEvent OnGameOver;
    public void TriggerGameOver()
    {
        OnGameOver.Invoke();
    }
}
