using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    private const string TAG_ACTIVATOR = "Activator";
    private const string TAG_MISSED = "Missed";

    [SerializeField]private bool _canBepressed;
    [SerializeField] private KeyCode _keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_keyToPress))
        {
            if (_canBepressed)
            {
                Destroy(gameObject);
                GameManager.Instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == TAG_ACTIVATOR)
        {
            _canBepressed = true;
        }
        else if (other.tag == TAG_MISSED)
        {
            _canBepressed = false;
            GameManager.Instance.NoteMissed();
        }
    }

    /*
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            _canBepressed = false;
            GameManager.Instance.NoteMissed();
        }
    }
    */
}
