using UnityEngine;

public class WhiteGenerator : MonoBehaviour
{
    [SerializeField]
    private int _instanceNum = 1000;

    [SerializeField]
    private GameObject _white = null;

    private void Awake()
    {
        for (var i = 0; i < _instanceNum; i++)
        {
            Instantiate(_white, transform);
        }
    }

}
