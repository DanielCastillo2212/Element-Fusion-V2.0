using UnityEngine;


public class LeversManager : MonoBehaviour
{
    public GameObject lever02;
    public GameObject target02;

    public GameObject portal03;
    public GameObject lever01;

    // Gettig their controllers
    LeverController lc02;
    LeverController lc01;
    PortalController pc03;

    // Start is called before the first frame update
    void Start()
    {
        lc02 = lever02.GetComponent<LeverController>();
        lc01 = lever01.GetComponent<LeverController>();
        pc03 = portal03.GetComponent<PortalController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lc02.isOpen) useLever02();
        if (lc01.isOpen) useLever01();

        if (lc02.isOpen && lc01.isOpen) Destroy(this);
    }

    private void useLever02()
    {
        Destroy(target02);
    }

    private void useLever01()
    {
        pc03.active = true;
        Debug.Log("$Portal 03 activated");
    }

}
