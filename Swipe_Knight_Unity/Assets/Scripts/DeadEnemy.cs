using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEnemy : MonoBehaviour
{
    private void Start()
    {
        Invoke("SafetyCatch", 5);
    }

    void SafetyCatch()
    {
        Destroy(this.gameObject);
    }

}
