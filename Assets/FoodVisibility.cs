using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodVisibility : MonoBehaviour
{
    public GameObject[] Food;
    public int CurrentIndex;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (CurrentIndex >= 0)
            {
                Food[CurrentIndex].SetActive(false);
                CurrentIndex--;
                Food[CurrentIndex].SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(CurrentIndex < Food.Length)
            {
                Food[CurrentIndex].SetActive(false);
                CurrentIndex++;
                Food[CurrentIndex].SetActive(true);
            }
        }
        if(CurrentIndex > 17 || CurrentIndex<0)
        {
            CurrentIndex = 1;
        }
    }
        void DeactivateAll()
        {
            for (int i = 0; i < Food.Length; i++)
            {
                Food[i].SetActive(false);


            }
        }
    void ActivateByIndex(int index)
    {
        Food[index].SetActive(true);
    }
}