using UnityEngine;
using DG.Tweening;

public class ScrollingWorldObjects
{
    private readonly Transform[] _allObjects;
    private readonly float _distanceBetweenObjects;
    private readonly float _durationSwipe;
    private readonly Camera _camera;
    private int _currentIndex;

    public ScrollingWorldObjects(Transform[] allObjects, float distanceBetweenObjects, float durationSwipe, Camera camera, int currentIndex)
    {
        _allObjects = allObjects;
        _distanceBetweenObjects = distanceBetweenObjects;
        _durationSwipe = durationSwipe;
        _camera = camera;
        SetInitialPositions(currentIndex);
    }

    private void SetInitialPositions(int currentItemIndex)
    {
        int clampedValue = Mathf.Clamp(currentItemIndex, 0, _allObjects.Length - 1);
        _currentIndex = clampedValue;
        float distanceToCamera = clampedValue * _distanceBetweenObjects;

        float startPositionX = _camera.transform.position.x - distanceToCamera;

        float distanceBetweenObjectsLocal = 0;
        for (int i = 0; i < _allObjects.Length; i++)
        {
            _allObjects[i].transform.position =
                new Vector3(startPositionX + distanceBetweenObjectsLocal, _allObjects[i].transform.position.y, _allObjects[i].transform.position.z);
            distanceBetweenObjectsLocal += _distanceBetweenObjects;
        }
    }

    public void NextItem()
    {
        if (_currentIndex == _allObjects.Length - 1)
        {
            _currentIndex = 0;
        } else
        {
            _currentIndex++;
        }
        Move();
    }

    public void PreviousItem()
    {
        if (_currentIndex == 0)
        {
            _currentIndex = _allObjects.Length - 1;
        } else
        {
            _currentIndex--;
        }
        Move();
    }

    private void Move()
    {
        float distanceToCamera = _currentIndex * _distanceBetweenObjects;
        float startPositionX = _camera.transform.position.x - distanceToCamera;
        float distanceBetweenObjectsLocal = 0;
        for (int i = 0; i < _allObjects.Length; i++)
        {
            _allObjects[i].transform.DOMoveX(startPositionX + distanceBetweenObjectsLocal, _durationSwipe).SetEase(Ease.InOutBack);
            distanceBetweenObjectsLocal += _distanceBetweenObjects;
        }
    }
    public void MoveByIndex(int index)
    {
        _currentIndex = index;
        Move();
    }
}
