using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Prosty mechanizm poruszania się za kursorem
    /// </summary>
    [RequireComponent(typeof(SpriteFlipper))]
    public class CursorFollow : MonoBehaviour
    {
        private Vector3 _MousePosition;
        [SerializeField] private float moveSpeed = 0.05f;

        /// <summary>Update is called once per frame </summary>
        void Update()
        {
            if (!FindObjectOfType<PauseMenu>().Paused)
            {
                if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
                {
                    _MousePosition = Input.mousePosition;
                    _MousePosition = Camera.main.ScreenToWorldPoint(_MousePosition);
                    transform.position = Vector2.Lerp(transform.position, _MousePosition, moveSpeed);
                }
            }
        }
        /// <summary>
        /// Niszczenie przedmioty na który się najedzie ("zjadanie itemów")
        /// </summary>
        /// <param name="collision"></param>
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(collision.gameObject);
        }

    }
}
