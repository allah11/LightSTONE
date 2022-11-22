using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public static int TheCherry;
    public Text TextCherry;

    void Start()
    {
        TextCherry = GetComponent<Text>();
    }
                                                        //необходим для счётчика красных кругов
    // Update is called once per frame
    void Update()
    {
        TextCherry.text = "x" + TheCherry;
    }
}
