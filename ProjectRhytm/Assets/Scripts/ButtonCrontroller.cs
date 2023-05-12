using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCrontroller : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _defaultImage;
    [SerializeField] private Sprite _pressedImage;

    [SerializeField] private KeyCode _keypressed;


    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_keypressed))
        {
            _spriteRenderer.sprite = _pressedImage;
        }

        if (Input.GetKeyUp(_keypressed))
        {
            _spriteRenderer.sprite = _defaultImage;
        }


    }
}
