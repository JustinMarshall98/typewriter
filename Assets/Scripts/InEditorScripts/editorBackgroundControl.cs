﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class editorBackgroundControl : MonoBehaviour
{

    private SpriteRenderer render;
    
    void Update()
    {
        render = GetComponent<SpriteRenderer>();
        transform.localScale=new Vector3(1,1,1);
 
        float width=render.sprite.bounds.size.x;
        float height=render.sprite.bounds.size.y;
 
 
        float worldScreenHeight = Camera.main.orthographicSize * 2f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
 
        Vector3 xWidth = transform.localScale;
        xWidth.x=worldScreenWidth / width;
        transform.localScale=xWidth;
        //transform.localScale.x = worldScreenWidth / width;
        Vector3 yHeight = transform.localScale;
        yHeight.y=worldScreenHeight / height;
        transform.localScale=yHeight;
        //transform.localScale.y = worldScreenHeight / height;
    }
}
