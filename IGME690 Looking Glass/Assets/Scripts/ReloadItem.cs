using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadItem : MonoBehaviour
{
    //this is just where the ceiling game object is so i don't place the item above it
    public Transform ceiling;
    //all the bouncy items in order that they will replace each other
    public List<GameObject> itemsToDrop;

    //where we currently are in the list
    private int currentItem = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //remove last item
        itemsToDrop[currentItem].SetActive(false);
        //iterate to next item
        currentItem++;
        //make sure that the next item actually exists
        if (currentItem > itemsToDrop.Count - 1) { currentItem = 0; }
        //set the current item to active
        itemsToDrop[currentItem].SetActive(true);
        //place it right below the ceiling
        itemsToDrop[currentItem].GetComponent<Transform>().position = new Vector3(0, ceiling.position.y - 1f, 0);
    }
}
