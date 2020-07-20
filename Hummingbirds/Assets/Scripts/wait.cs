using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class wait : MonoBehaviour
{
   public void pengiun()
    {
        SceneManager.LoadScene(1);
    }
    public void humming_bird()
    {
        SceneManager.LoadScene(2);
    }
    public void backtomain()
    {
        SceneManager.LoadScene(0);
    }
}
