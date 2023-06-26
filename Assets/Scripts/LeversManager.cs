using UnityEngine;


public class LeversManager : MonoBehaviour
{
    public GameObject lever02;
    public GameObject target02;

    // Gettig their controllers
    LeverController lc02;

    // Start is called before the first frame update
    void Start()
    {
        lc02 = lever02.GetComponent<LeverController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lc02.isOpen) useLever02();

    }

    private void useLever02()
    {
        Destroy(target02);
    }
}
