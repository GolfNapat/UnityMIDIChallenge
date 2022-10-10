using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    InputManager inputManager;

    [SerializeField] private GameObject startBotton;

    private void Awake()
    {
        inputManager = GetComponentInChildren<InputManager>();
        startBotton.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        inputManager.gameStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        StartHanler();
        RestartHandler();
    }

    private void StartHanler()
    {
        if (inputManager.space_Flag == true && inputManager.gameStart)
        {
            inputManager.gameStart = false;
            startBotton.SetActive(false);
        }

        if (inputManager.gameStart == false && SongManager.Instance.isPlay == false)
        {
            SongManager.Instance.isPlay = true;
            SongManager.Instance.GetDataFromMidi();
        }
    }

    private void RestartHandler()
    {
        if(SongManager .Instance .canReStart)
        {
            Debug.Log("reLoad");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
