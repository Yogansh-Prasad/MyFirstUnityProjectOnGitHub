using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Button Button1;
    public Button Button2;
    public Button Button3;
    /*public Button Button4;*/
    
    /*public string Mainscene;*/
    


    private void Start()
    {
        
        Button1.onClick.AddListener(LoadScene1);
        Button2.onClick.AddListener(Load2ndScene);
        Button3.onClick.AddListener(Load3rdScene);
       /* Button4.onClick.AddListener(OnButtonClick4);*/


    }
    
    public void LoadScene1()
    {
        
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }

    public void Load2ndScene()
    {

        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
    public void Load3rdScene()
    {

        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }

    /*public void OnButtonClick4()
    {

        SceneManager.LoadScene(Mainscene);
    }
*/


}
