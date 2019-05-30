using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrestlerRender : MonoBehaviour
{
    public Wrestler WrestlerStyle;
    public Image _image;

    // Use this for initialization
    void Start()
    {
        _image.sprite = WrestlerStyle.SpriteIcon;
    }
}
