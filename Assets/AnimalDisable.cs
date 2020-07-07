using UnityEngine;

namespace DefaultNamespace
{
    public class AnimalDisable : MonoBehaviour
    {
        public void Disable()
        {
            gameObject.SetActive(false);
        }
    }
}