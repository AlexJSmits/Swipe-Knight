using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{

    public GameObject _swipeGO;
    private Rigidbody _swipeRB;

    void Start()
    {
        _swipeGO.SetActive(false);
    }


    void Update()
    {

        //Mouse Controls
        if (Input.GetMouseButton(0))
        {
            _swipeGO.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _swipeGO.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _swipeGO.SetActive(false);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") /*&& _swipeRB.velocity.sqrMagnitude >= 0.1f*/)
        {
            collision.gameObject.GetComponent<Enemy>().Death();
        }
    }
}
