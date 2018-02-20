using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private GameObject _Background;
    [SerializeField] private float _MaxCameraSize = 25.0f;
    [SerializeField] private float _MinCameraSize = 8.0f;
    private const float _Backgroundfactor = 0.3f;
    private float _ScrollWhell;

    // Update is called once per frame
    void Update()
    {
        _ScrollWhell = Input.GetAxis("Mouse ScrollWheel");
        if (_ScrollWhell > 0 && gameObject.GetComponent<Camera>().orthographicSize > _MinCameraSize)
        {
            gameObject.GetComponent<Camera>().orthographicSize--;
            if (_Background.transform.localScale.x > 1)
            {
                _Background.transform.localScale -= new Vector3(_Backgroundfactor, _Backgroundfactor, _Backgroundfactor);
            }
        }

        if (_ScrollWhell < 0 && gameObject.GetComponent<Camera>().orthographicSize < _MaxCameraSize)
        {
            gameObject.GetComponent<Camera>().orthographicSize++;
            _Background.transform.localScale += new Vector3(_Backgroundfactor, _Backgroundfactor, _Backgroundfactor);
        }
    }

}
