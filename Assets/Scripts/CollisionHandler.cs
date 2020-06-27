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
        Invoke("ReoladScene", levelLoadDelay);
    }
    private void StartDeathSequence() 
    {
        SendMessage("OnPlayerDeath");
    }

    //fixe reload scene
    private void ReloadScene() 
    {
        SceneManager.LoadScene(1);
    }
}
