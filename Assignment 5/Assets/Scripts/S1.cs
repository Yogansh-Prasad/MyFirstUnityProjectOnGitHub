using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S1 : MonoBehaviour
{
    public Button Button1;
    

    private void Start()
    {

        Button1.onClick.AddListener(OnButtonClick);

    }

    public void OnButtonClick()
    {

        SceneManager.LoadScene(0);
    }
}
