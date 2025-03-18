using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateClick : MonoBehaviour
{
    public TMP_Text Text;
    public float Click;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Click Clicks:" + Click.ToString("0");
    }

    public void addClick()
    {
        Click++;
        
    }
}
