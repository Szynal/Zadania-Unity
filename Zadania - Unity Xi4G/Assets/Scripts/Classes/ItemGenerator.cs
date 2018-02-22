using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class ItemGenerator : MonoBehaviour
    {
        /// <summary>
        /// Maksymalna możliwa liczba do ustalenia (Maksymalne występowanie  na scenie)
        /// </summary>
        private const int MaximumAmount = 10;

        /// <summary>
        /// Minimalna możliwa liczba do ustalenia (Minimalne występowanie  na scenie)
        /// </summary>
        private const int MinimalAmount = 1;

        [SerializeField] private GameObject _Player;
        /// <summary>
        /// Suwak dla designer 
        /// </summary>
        [Range(MinimalAmount, MaximumAmount)] [SerializeField] private int _MaxItemsQuantity = 5;
        [SerializeField] public List<GameObject> _ItemList;
        private GameObject item;

        private System.Random generator;
        private float _Width = 8.0f;
        private float _Height = 5.0f;

        private void Start()
        {
            Generator();
        }

        private void Update()
        {
            ZoomItemPosition();
            if (gameObject.transform.childCount == 0)
            {
                Generator();
            }
        }
        /// <summary>
        /// Tworzy w losowej ilosci itemy, co najmniej jeden każdego rodzaju na losowej pozycji, ale ZAWSZE w polu widzenia kamery./// </summary>
        private void Generator()
        {
            generator = new System.Random();

            for (int i = 0; i < _ItemList.Count; i++)
            {
                int randomValue = generator.Next(1, _MaxItemsQuantity);
                for (int q = 0; q < randomValue; q++)
                {
                    item = Instantiate(_ItemList[i], new Vector3((Random.value * 2 - 1) * _Width, (Random.value * 2 - 1) * _Height, 0), Quaternion.identity, gameObject.transform);
                    item.name = _ItemList[i].name;
                }
            }
        }
        /// <summary>
        /// Aktualizacja zasięgu pojawiania się przedmiotu względem zoomowania 
        /// </summary>
        private void ZoomItemPosition()
        {

            float _ScrollWhell = Input.GetAxis("Mouse ScrollWheel");
            if (_ScrollWhell > 0 && _Player.transform.GetChild(0).GetComponent<Camera>().orthographicSize > _Player.transform.GetChild(0).GetComponent<CameraZoom>()._MinCameraSize)
            {
                _Width -= 0.8f;
                _Height -= 0.6f;
            }

            if (_ScrollWhell < 0 && _Player.transform.GetChild(0).GetComponent<Camera>().orthographicSize < _Player.transform.GetChild(0).GetComponent<CameraZoom>()._MaxCameraSize)
            {
                _Width += 0.8f;
                _Height += 0.6f;
            }
        }


    }
}
