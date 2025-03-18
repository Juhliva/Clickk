using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateClick : MonoBehaviour
{
    public TMP_Text Text;
    private int Click;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addClick()
    {
        Click++;
        Text.text = "Click Clicks:" + Click;
    }
}
