﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wararyo.TaskGround
{

    public class TaskPin : MonoBehaviour
    {
        public Transform player;
        public float size = 1;
        public float scaleFactor = 0.1f;
        public float minSize = 0.2f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //ずっとこっち向く
            Vector3 target = Camera.main.transform.position;
            target.y = this.transform.position.y;
            this.transform.LookAt(target);


            //遠くに行くほど大きくなるか小さくなる
            float distance = Vector3.Distance(player.position, transform.position);
            float scale = Mathf.Max(minSize,size + (scaleFactor * distance));
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }

}