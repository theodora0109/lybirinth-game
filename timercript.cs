using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timerscript : MonoBehaviour
{
    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;

    private float oldSeconds;
    //タイマー表示テキスト
    private Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if(seconds >= 60f){
            minute++;
            seconds = seconds - 60;
        }
        if((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int) seconds).ToString("00"); 
        }
        oldSeconds = seconds;
    }
}

