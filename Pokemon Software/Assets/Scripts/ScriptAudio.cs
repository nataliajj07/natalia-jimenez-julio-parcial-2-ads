using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAudio: MonoBehaviour
{
    public static ScriptAudio inst;
    private void Awake()
    {
        if (ScriptAudio.inst == null)
        {
            ScriptAudio.inst = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
