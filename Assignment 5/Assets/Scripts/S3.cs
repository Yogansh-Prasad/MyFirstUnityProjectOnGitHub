using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S3 : MonoBehaviour
{
    public Button Button3;
    

    private void Start()
    {

        Button3.onClick.AddListener(OnButtonClick);

    }

    public void OnButtonClick()
    {

        SceneManager.LoadScene(0);
    }
}
