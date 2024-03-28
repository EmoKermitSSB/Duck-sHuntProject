using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrollSceneExit : MonoBehaviour
{
    public void RickRollExit()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
