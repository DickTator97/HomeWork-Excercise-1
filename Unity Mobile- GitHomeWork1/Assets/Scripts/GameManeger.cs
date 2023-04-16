using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Maneger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject touchObjectToSpawn;
    //[SerializeField] private RectTransform MainCanvasTransform;
    //[SerializeField] private Image TargetImageToAffect;
    //[SerializeField] private RectTransform Target TargatImageRectTransform;
    [SerializeField] private Camera MainCamera;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch CurrentTouch = Input.touches[i];
            if (CurrentTouch.phase==TouchPhase.Began)
            {
                Vector3 SpawnPosition=new Vector3(CurrentTouch.position.x,CurrentTouch.position.y);
                SpawnPosition=MainCamera.ScreenToWorldPoint(SpawnPosition);
                Instantiate(touchObjectToSpawn,SpawnPosition,touchObjectToSpawn.transform.rotation);
                if (Input.touchCount>1)
                {
                    Debug.Log("Multiple Touches");
               
                } else if(Input.touchCount <= 1)
                {
                    Debug.Log("One Touch");
                }
                
            }
        }
    }
}
