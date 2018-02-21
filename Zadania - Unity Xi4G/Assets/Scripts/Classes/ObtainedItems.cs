using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ObtainedItems : MonoBehaviour
    {
        private GameObject _textModul;
        private GameObject _TextUI;
        private GameObject _CanvasUI;

        void Start()
        {
            for (int i = 0; i < FindObjectOfType<ItemGenerator>()._ItemList.Count; i++)
            {
                CreateObject(out _textModul, transform, "Collected " + FindObjectOfType<ItemGenerator>()._ItemList[i].name);
                CreateCanvasUI();
                CreateTextUI(FindObjectOfType<ItemGenerator>()._ItemList[i].name + " x0", 5);
                _textModul.transform.position = new Vector3(12, 8 + 2 * i, 0);
            }
        }

        private void Update()
        {
            for (int i = 0; i < FindObjectOfType<ItemGenerator>()._ItemList.Count; i++)
            {
                gameObject.transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<ItemGenerator>()._ItemList[i].name + " x" + FindObjectOfType<ItemCollecting>().CollectedItems[i];
            }
        }


        private void CreateObject(out GameObject gameObject, Transform parent, String name)
        {
            gameObject = new GameObject();
            gameObject.transform.parent = parent;
            gameObject.name = name;
        }

        private void CreateCanvasUI()
        {
            CreateObject(out _CanvasUI, _textModul.transform, "CanvasUI");
            _CanvasUI.AddComponent<Canvas>();
            _CanvasUI.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, 0, 0);
            _CanvasUI.GetComponent<RectTransform>().localScale = new Vector3(0.2f, 0.2f, 0.2f);

        }

        private void CreateTextUI(String textName, int textSize)
        {
            CreateObject(out _TextUI, _CanvasUI.transform, "TextUI");
            _TextUI.AddComponent<Text>();
            _TextUI.GetComponent<Text>().text = textName;
            _TextUI.GetComponent<Text>().transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            _TextUI.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            _TextUI.GetComponent<Text>().fontSize = textSize;
            _TextUI.GetComponent<Text>().font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
            _TextUI.GetComponent<Text>().resizeTextForBestFit = true;
            _TextUI.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
            RectTransform rectTextTransform = _TextUI.GetComponent<RectTransform>();
            rectTextTransform.sizeDelta = new Vector2(100, 50);
        }



    }
}
