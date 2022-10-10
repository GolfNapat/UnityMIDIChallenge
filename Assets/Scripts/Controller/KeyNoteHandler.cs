using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyNoteHandler : MonoBehaviour
{
    public Renderer rend;
    [SerializeField] private InputOption objectKey;

    public Material[] materials;

    public GameObject canPushItem;

    public bool onTime;

    public int numSlot;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    private void Start()
    {
        numSlot = (int)objectKey.thisKey;
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Note")
        {
            Debug.Log("time to push");
            canPushItem = other.gameObject;
            onTime = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other .gameObject .tag == "Note")
        {
            Debug.Log("hold");
            canPushItem = null;
            onTime = false;
        }
    }

}
