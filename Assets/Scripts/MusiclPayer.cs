using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusiclPayer : MonoBehaviour
{

    private void Awake() 
    {
      DontDestroyOnLoad(this.gameObject);
    }
}
