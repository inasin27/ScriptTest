using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {

        //�v�f5�̔z��array�Ő錾����
        int[] array = new int[5];

        //�z��ɍD���Ȑ����ŏ���������
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        //�z��̗v�f�����Ԃɕ\��������
        for (int n = 0; n < 5; n++)
        {
            Debug.Log(array[n]);
        }
        //�z��̗v�f���t���ŕ\��������
        for (int m = 4; m >= 0; m--)
        {
            Debug.Log(array[m]);
        }
    }

    void Update()
    {

    }
}

