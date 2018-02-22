using UnityEngine;

namespace Assets.Scripts
{
    public class ObjectDisable : MonoBehaviour
    {
        /// <summary>Update is called once per frame </summary>
        void Update()
        {
            if (!FindObjectOfType<PauseMenu>().Paused)
            {
                gameObject.GetComponent<Renderer>().enabled = true;
            }
            else
            {
                gameObject.GetComponent<Renderer>().enabled = false;
            }
        }

    }
}