using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    ScoreManager scoreManager;

    KeyNoteHandler keyHandlerInA;
    KeyNoteHandler keyHandlerInS;
    KeyNoteHandler keyHandlerInD;
    KeyNoteHandler keyHandlerInF;
    KeyNoteHandler keyHandlerInG;
    KeyNoteHandler keyHandlerInH;

    [SerializeField]
    private GameObject aButtonKey;
    [SerializeField]
    private GameObject sButtonKey;
    [SerializeField]
    private GameObject dButtonKey;
    [SerializeField]
    private GameObject fButtonKey;
    [SerializeField]
    private GameObject gButtonKey;
    [SerializeField]
    private GameObject hButtonKey;

    public int score;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        scoreManager = GetComponent<ScoreManager>();
        KeyHandlerHub();
    }

    private void KeyHandlerHub()
    {
        keyHandlerInA = aButtonKey.GetComponent<KeyNoteHandler>();
        keyHandlerInS = sButtonKey.GetComponent<KeyNoteHandler>();
        keyHandlerInD = dButtonKey.GetComponent<KeyNoteHandler>();
        keyHandlerInF = fButtonKey.GetComponent<KeyNoteHandler>();
        keyHandlerInG = gButtonKey.GetComponent<KeyNoteHandler>();
        keyHandlerInH = hButtonKey.GetComponent<KeyNoteHandler>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.KeyInputHandler();
        scoreManager.ScoreHandler();
        CheckKeyHub();
    }

    private void CheckKeyHub()
    {
        CheckInputA();
        CheckInputS();
        CheckInputD();
        CheckInputF();
        CheckInputG();
        CheckInputH();
    }

    private void CheckInputA()
    {

        if (keyHandlerInA.numSlot == 0)
        {
            if (inputManager.a_Flag)
            {
                inputManager.a_Flag = false;
                keyHandlerInA.rend.sharedMaterial = keyHandlerInA.materials[1];

                if (keyHandlerInA.onTime == true)
                {
                    Destroy(keyHandlerInA.canPushItem);
                    score++;

                    keyHandlerInA.onTime = false;
                }
            }
            else
            {
                keyHandlerInA.rend.sharedMaterial = keyHandlerInA.materials[0];
            }
        }
    }
    private void CheckInputS()
    {
        if (keyHandlerInS.numSlot == 1)
        {
            if (inputManager.s_Flag)
            {
                inputManager.s_Flag = false;
                keyHandlerInS.rend.sharedMaterial = keyHandlerInS.materials[1];

                if (keyHandlerInS.onTime == true)
                {
                    Destroy(keyHandlerInS.canPushItem);
                    score++;

                    keyHandlerInS.onTime = false;
                }
            }
            else
            {
                keyHandlerInS.rend.sharedMaterial = keyHandlerInS.materials[0];
            }
        }
    }

    private void CheckInputD()
    {
        if (keyHandlerInD.numSlot == 2)
        {
            if (inputManager.d_Flag)
            {
                inputManager.d_Flag = false;
                keyHandlerInD.rend.sharedMaterial = keyHandlerInD.materials[1];

                if (keyHandlerInD.onTime == true)
                {
                    Destroy(keyHandlerInD.canPushItem);
                    score++;

                    keyHandlerInD.onTime = false;
                }
            }
            else
            {
                keyHandlerInD.rend.sharedMaterial = keyHandlerInD.materials[0];
            }
        }
    }

    private void CheckInputF()
    {
        if (keyHandlerInF.numSlot == 3)
        {
            if (inputManager.f_Flag)
            {
                inputManager.f_Flag = false;
                keyHandlerInF.rend.sharedMaterial = keyHandlerInF.materials[1];

                if (keyHandlerInF.onTime == true)
                {
                    Destroy(keyHandlerInF.canPushItem);
                    score++;

                    keyHandlerInF.onTime = false;
                }
            }
            else
            {
                keyHandlerInF.rend.sharedMaterial = keyHandlerInF.materials[0];
            }
        }
    }

    private void CheckInputG()
    {
        if (keyHandlerInG.numSlot == 4)
        {
            if (inputManager.g_Flag)
            {
                inputManager.g_Flag = false;
                keyHandlerInG.rend.sharedMaterial = keyHandlerInG.materials[1];

                if (keyHandlerInG.onTime == true)
                {
                    Destroy(keyHandlerInG.canPushItem);
                    score++;

                    keyHandlerInG.onTime = false;
                }
            }
            else
            {
                keyHandlerInG.rend.sharedMaterial = keyHandlerInG.materials[0];
            }
        }
    }

    private void CheckInputH()
    {
        if (keyHandlerInH.numSlot == 5)
        {
            if (inputManager.h_Flag)
            {
                inputManager.h_Flag = false;
                keyHandlerInH.rend.sharedMaterial = keyHandlerInH.materials[1];

                if (keyHandlerInH.onTime == true)
                {
                    Destroy(keyHandlerInH.canPushItem);
                    score++;

                    keyHandlerInH.onTime = false;
                }
            }
            else
            {
                keyHandlerInH.rend.sharedMaterial = keyHandlerInH.materials[0];
            }
        }
    }
}
