using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public static BeatScroller Instance { get; private set; }
    [SerializeField] private float _beatTempo;
    private bool _hasStarted;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _beatTempo /= 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (_hasStarted)
        { 
            transform.position -= new Vector3(0f, _beatTempo * Time.deltaTime, 0f);
        }
    }

    public void StartArrowsScrolling()
    {
        _hasStarted = true;
    }
}
