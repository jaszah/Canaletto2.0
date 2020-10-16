using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickChecker : MonoBehaviour
{
    public GameObject syrenka1;
    public GameObject syrenka2;
    public GameObject syrenka3;
    public int lostHearts = 0;

    public static bool openWinStarted = false;

    private float timeSinceLastClick;
    private float lastClickTime;

    private static float DOUBLE_CLICK_TIME = .2f;

    private void OnMouseDown()
	{
        if (Input.GetMouseButtonDown(0))
        {
            timeSinceLastClick = Time.time - lastClickTime;

            if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
            {
                //tutaj trzeba dać zmienną do double żeby sie wysłała
                Debug.Log("double od clickera");
                if (!openWinStarted && lostHearts < 3)
                {
                    switch (lostHearts)
                    {
                        case 0:
                            syrenka1.GetComponent<Animator>().SetBool("IsOn", false);
                            Destroy(syrenka1, 2.5f);
                            lostHearts++;
                            openWinStarted = false;
                            break;
                        case 1:
                            syrenka2.GetComponent<Animator>().SetBool("IsOn", false);
                            Destroy(syrenka2, 2.5f);
                            lostHearts++;
                            openWinStarted = false;
                            break;
                        case 2:
                            syrenka3.GetComponent<Animator>().SetBool("IsOn", false);
                            Destroy(syrenka3, 2.5f);
                            lostHearts++;
                            openWinStarted = false;
                            break;
                    }
                }
                else
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
            lastClickTime = Time.time;
        }
    }
}
