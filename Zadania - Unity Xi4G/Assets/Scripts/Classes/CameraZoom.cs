using UnityEngine;

namespace Assets.Scripts
{
    public class CameraZoom : MonoBehaviour
    {
        [SerializeField] private GameObject _Background;
        [SerializeField] private GameObject _ItemColector;
        [SerializeField] private GameObject _PasueMenu;
        [SerializeField] public float _MaxCameraSize = 25.0f;
        [SerializeField] public float _MinCameraSize = 8.0f;
        private const float _Backgroundfactor = 0.3f;
        private float _ScrollWhell;
        private Camera _Camera;

        private void Start()
        {
            _Camera = gameObject.GetComponent<Camera>();
        }
        // Update is called once per frame
        void Update()
        {
            _ScrollWhell = Input.GetAxis("Mouse ScrollWheel");
            if (_ScrollWhell > 0 && gameObject.GetComponent<Camera>().orthographicSize > _MinCameraSize)
            {
                gameObject.GetComponent<Camera>().orthographicSize--;
                if (_Background.transform.localScale.x > 1)
                {
                    _Background.transform.localScale += new Vector3(_Backgroundfactor, _Backgroundfactor, _Backgroundfactor);

                    if (_ItemColector.transform.childCount > 0)
                    {
                        for (int i = 0; i < FindObjectOfType<ItemCollecting>().CollectedItems.Length; i++)
                        {
                            _ItemColector.transform.GetChild(i).transform.position -= new Vector3(1.2f, 1f, 0);
                        }
                    }
                }
                _PasueMenu.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, 0, (-30) * _Camera.orthographicSize);

            }

            if (_ScrollWhell < 0 && gameObject.GetComponent<Camera>().orthographicSize < _MaxCameraSize)
            {
                gameObject.GetComponent<Camera>().orthographicSize++;
                _Background.transform.localScale += new Vector3(_Backgroundfactor, _Backgroundfactor, _Backgroundfactor);
                if (_ItemColector.transform.childCount > 0)
                {
                    for (int i = 0; i < FindObjectOfType<ItemCollecting>().CollectedItems.Length; i++)
                    {
                        _ItemColector.transform.GetChild(i).transform.position += new Vector3(1.2f, 1f, 0);
                    }
                }

                _PasueMenu.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, 0, (-30) / _Camera.orthographicSize);

            }
        }
    }
}
