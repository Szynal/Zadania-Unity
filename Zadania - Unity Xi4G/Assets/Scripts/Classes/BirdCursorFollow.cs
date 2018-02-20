using UnityEngine;

namespace Scripts
{
    public class BirdCursorFollow : MonoBehaviour
    {
        private Vector3 _MousePosition;
        [SerializeField] private float moveSpeed = 0.05f;

        /// <summary>Update is called once per frame </summary>
        void Update()
        {
            if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
            {
                _MousePosition = Input.mousePosition;
                _MousePosition = Camera.main.ScreenToWorldPoint(_MousePosition);
                transform.position = Vector2.Lerp(transform.position, _MousePosition, moveSpeed);
            }
        }

    }



}
