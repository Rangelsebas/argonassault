using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject DeathFX;
    [SerializeField] float levelLoadDelay = 1f;
    void OnTriggerEnter(Collider other) 
    {
        StartDeathSequence();
        DeathFX.SetActive(true);
    }
    private void StartDeathSequence() 
    {
        SendMessage("OnPlayerDeath");
    }
}
