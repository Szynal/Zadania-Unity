using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    ///  włączanie i wyłączanie komponentu Renderer
    /// </summary>
    public class ObjectDisable : MonoBehaviour
    {
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