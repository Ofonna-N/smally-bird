using UnityEngine.SceneManagement;
using UnityEngine;

namespace SmallyBird
{
    public class LoadLevel : MonoBehaviour
    {

        public void Load(int level)
        {
            SceneManager.LoadScene(level);
        }
    }
}
