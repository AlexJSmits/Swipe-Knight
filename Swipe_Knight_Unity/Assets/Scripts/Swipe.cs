using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{

    public GameObject _swipeGO;

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
}
