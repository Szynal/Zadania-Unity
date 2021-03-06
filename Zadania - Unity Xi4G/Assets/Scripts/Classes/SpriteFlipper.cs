﻿using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Odwraca Sprita wzgledem położenia kursora myszy
    /// </summary>
    public class SpriteFlipper : MonoBehaviour
    {
        void Update()
        {

            if (gameObject.transform.GetChild(0).GetComponent<Camera>().WorldToScreenPoint(transform.position).x < Input.mousePosition.x)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;

            }
            if (gameObject.transform.GetChild(0).GetComponent<Camera>().WorldToScreenPoint(transform.position).x > Input.mousePosition.x)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;

            }
        }
    }
}



