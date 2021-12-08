using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {

        //要素5の配列arrayで宣言する
        int[] array = new int[5];

        //配列に好きな数字で初期化する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        //配列の要素を順番に表示させる
        for (int n = 0; n < 5; n++)
        {
            Debug.Log(array[n]);
        }
        //配列の要素を逆順で表示させる
        for (int m = 4; m >= 0; m--)
        {
            Debug.Log(array[m]);
        }
    }

    void Update()
    {

    }
}

