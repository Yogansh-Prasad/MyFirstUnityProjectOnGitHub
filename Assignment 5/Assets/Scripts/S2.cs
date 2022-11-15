using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S2 : MonoBehaviour
{
    public Button Button2;
    

    private void Start()
    {

        Button2.onClick.AddListener(OnButtonClick);

    }

    public void OnButtonClick()
    {

        SceneManager.LoadScene(0);
    }
}
