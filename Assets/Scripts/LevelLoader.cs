using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlexzanderCowell
{
    public class LevelLoader : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                LoadLevel("WeekTwoActivites");
            }
            

        }


        /// <summary>
        /// Level Loader
        /// </summary>
        private void LoadLevel(string sceneToLoad)
        {
            SceneManager.LoadScene(sceneToLoad);
        }

    }
}
