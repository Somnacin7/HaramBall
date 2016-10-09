<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;
=======
﻿using UnityEngine;
using System.Collections;
>>>>>>> grey
using UnityEngine.SceneManagement;

public class FallDetector : MonoBehaviour
{

    void OnTriggerExit(Collider player)
    {

        if (player.gameObject.tag == "Player")
        {
            //Death stuff
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        }
    }
}