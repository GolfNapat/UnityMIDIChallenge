using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public int noteValue;

    public int noteScore = 20;

    public KeyCode noteKeyCode;

    public Vector3 spawnPos { get; private set; }

    private string currentKeyPressed;

    private KeyCode[] keyValues;

    [SerializeField]
    private int despawnOffset = 20;

    [SerializeField]
    private Vector3 noteIndicatorPos;

    [SerializeField]
    private float marginOfError = 1;

    void Start()
    {
        spawnPos = transform.position;
    }

    void Update()
    {
        CheckNote(noteIndicatorPos,
        marginOfError,
        SongManager.Instance.currentKeyPressedList,
        noteKeyCode);
        NoteMove(SongManager.Instance.noteSpeed,
        SongManager.Instance.playerNoteSpeed);
    }

    public void NoteMove(float noteSpeed, float playerNoteSpeed)
    {
        Vector3 noteDirection =
            Vector3.left * noteSpeed * playerNoteSpeed * Time.deltaTime;
        transform.Translate (noteDirection);
    }

    public void CheckNote(
        Vector3 noteIndicatorPos,
        float marginOfError,
        List<KeyCode> currentKeyPressedList,
        KeyCode noteKeyCode
    )
    {
        float distance = Mathf.Abs(noteIndicatorPos.y - transform.position.y);
        if (distance <= marginOfError)
        {
            foreach (KeyCode key in currentKeyPressedList)
            {
                if (key == noteKeyCode)
                {
                    ScoreManager.Instance.Hit (noteScore);
                    Destroy (gameObject);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DespawnLine"))
        {
            Destroy (gameObject);
        }
    }
}
