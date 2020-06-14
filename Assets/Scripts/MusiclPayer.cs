using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusiclPayer : MonoBehaviour
{

    private void Awake() 
    {
      DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
      Invoke("LoadFirstLevel", 2f); 
    }

    private void LoadFirstLevel() 
    {
        SceneManager.LoadScene(1);
    }
}
