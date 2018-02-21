using UnityEngine;

namespace Assets.Scripts
{
    public class CanvasZoom : MonoBehaviour
    {
        [SerializeField] public float _MaxCameraSize = 25.0f;
        [SerializeField] public float _MinCameraSize = 8.0f;
        private float _ScrollWhell;

        void Update()
        {
            _ScrollWhell = Input.GetAxis("Mouse ScrollWheel");
            if (_ScrollWhell > 0 && FindObjectOfType<CameraZoom>().gameObject.GetComponent<Camera>().orthographicSize > _MinCameraSize)
            {
                gameObject.GetComponent<Camera>().orthographicSize--;
            }

            if (_ScrollWhell < 0 && gameObject.GetComponent<Camera>().orthographicSize < _MaxCameraSize)
            {
                gameObject.GetComponent<Camera>().orthographicSize++;
            }
        }
    }
}
