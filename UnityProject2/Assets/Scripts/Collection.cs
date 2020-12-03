using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public List<Collect> CollectableList;

    private void Start()
    {
        
        
        for (var i = 0; i < CollectableList.Count; i++)
        {
            var position = new Vector3(i*2,0,0);
            var item = CollectableList[i];
            var newItem = new GameObject(item.name);
            newItem.transform.position = position;
            var sprite = newItem.AddComponent<SpriteRenderer>();
            sprite.sprite = item.art;
            sprite.color = item.artcolor;
        }
    }
}
