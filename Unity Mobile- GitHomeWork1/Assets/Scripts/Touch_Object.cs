using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class Touch_Object : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;

    private void OnMouseUp()
    {
        SpriteRenderer.color = Random.ColorHSV();

    }
    private void OnMouseEnter()
    {
        throw new System.NotImplementedException();
    }
    private void OnMouseExit()
    {
        throw new System.NotImplementedException();
    }
}
