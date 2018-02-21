using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(CircleCollider2D))]
    public class Item : MonoBehaviour
    {
        [SerializeField] private int _TextSize = 5;
        [SerializeField] private string _Name;
        private GameObject _TextUI;
        private GameObject _CanvasUI;

        // Use this for initialization
        void Start()
        {
            CreateCanvasUI();
            CreateTextUI();
            SetCircleCollider();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void CreateObject(out GameObject gameObject, Transform parent, String name)
        {
            gameObject = new GameObject();
            gameObject.transform.parent = parent;
            gameObject.name = name;
        }

        private void CreateCanvasUI()
        {
            CreateObject(out _CanvasUI, transform, "CanvasUI");
            _CanvasUI.AddComponent<Canvas>();
            _CanvasUI.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, 2, 0);
            _CanvasUI.GetComponent<RectTransform>().localScale = new Vector3(0.2f, 0.2f, 0.2f);

        }

        private void CreateTextUI()
        {
            CreateObject(out _TextUI, _CanvasUI.transform, "TextUI");
            _TextUI.AddComponent<Text>();
            _TextUI.GetComponent<Text>().text = _Name;
            _TextUI.GetComponent<Text>().transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            _TextUI.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0.2f);
            _TextUI.GetComponent<Text>().fontSize = _TextSize;
            _TextUI.GetComponent<Text>().font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
            _TextUI.GetComponent<Text>().resizeTextForBestFit = true;
            _TextUI.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }


        private void SetCircleCollider()
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
            gameObject.GetComponent<CircleCollider2D>().radius = 1.0f;
        }
    }
}