using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGPrintShot : SGBaseShot
{
    //private static readonly string[] SPLIT = {""}


    public TextAsset paintDataText;

    public float paintCneterAngle = 180f;
    public float betweenAngle = 3f;
    public float nextLineDelay = 0.1f;

    private int nowIndex;
    private float delayTime;

    private List<List<int>> pointData;
    private float paintStartAngle;
    public override void Shot()
    {
       // if(projectileSpeed <= 0f || paintDataText == null    //�ؽ�Ʈ ���Ͼȿ� ��Ʈ�� �־�� shot�Լ�����
    }

   
 
    void Update()
    {
        
    }
}
