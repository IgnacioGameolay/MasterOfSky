using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    [ContextMenu("Fade In")]
    public void FadeIn()
    {
        spriteRenderer.DOFade(1, 2);
    }
    
    [ContextMenu("Fade Out")]
    public void FadeOut()
    {
        spriteRenderer.DOFade(0, 2);
    }

    private void Start()
    {
        FadeOut();
    }
}
