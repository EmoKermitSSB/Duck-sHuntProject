using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrollScene : MonoBehaviour
{
    public void RickRoll()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
