using System.Collections;
using UnityEngine;



public class ToggleVisibility : MonoBehaviour
{
    
    public GameObject GameObjectToHide;
    public float MinTime = 10.0f;
    public float MaxTime = 20.0f;

    void Start()
    {
        StartCoroutine(ToggleVisibilityCo(GameObjectToHide));
    }
    void Invoker()
    {
        Invoke("appearDisappear", Random.Range(2.0F, 5.0F));
    }
    private IEnumerator ToggleVisibilityCo(GameObject someObj)
    {
        if (someObj == null) yield break;

        while (true)
        {
            someObj.SetActive(!someObj.active);

            yield return new WaitForSeconds(Random.Range(MinTime, MaxTime));
        }

    }
    }
