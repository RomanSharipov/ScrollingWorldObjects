using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    [SerializeField] Button _nextButon;
    [SerializeField] Button _prevButon;
    [SerializeField] ScrollingWorldObjects _scrollingWorldObjects;
    [SerializeField] Transform[] _objects;
    
    private void Awake()
    {
        _scrollingWorldObjects = new ScrollingWorldObjects(
            allObjects:_objects,
            distanceBetweenObjects:5.0f,
            durationSwipe:0.3f,
            camera:Camera.main,
            1);
    }

    private void OnEnable()
    {
        _nextButon.onClick.AddListener(OnNextButton);
        _prevButon.onClick.AddListener(OnPreviousButtn);
    }
    private void OnDisable()
    {
        _nextButon.onClick.RemoveListener(OnNextButton);
        _prevButon.onClick.RemoveListener(OnPreviousButtn);
    }

    private void OnPreviousButtn()
    {
        _scrollingWorldObjects.PreviousItem();
    }

    private void OnNextButton()
    {
        _scrollingWorldObjects.NextItem();
    }

}
