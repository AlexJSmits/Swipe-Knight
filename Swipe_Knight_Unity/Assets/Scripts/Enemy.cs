using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject _deathReplacement;

    private void Start()
    {
        Invoke("SafetyCatch", 10);
    }


    public void Death()
    {
        var _replacement = Instantiate(_deathReplacement, transform.position, transform.rotation);
        _replacement.GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity;
        Destroy(this.gameObject);
    }

    void SafetyCatch()
    {
        Destroy(this.gameObject);
    }
}
