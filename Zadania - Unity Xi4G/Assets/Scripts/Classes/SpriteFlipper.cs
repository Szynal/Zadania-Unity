using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{
    [SerializeField] new Camera camera;

    // Update is called once per frame
    void Update()
    {

        if (camera.WorldToScreenPoint(transform.position).x < Input.mousePosition.x)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }
        if (camera.WorldToScreenPoint(transform.position).x > Input.mousePosition.x)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        }
    }


}



