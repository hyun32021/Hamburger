using UnityEngine;

public class RuleUIManager : MonoBehaviour
{
    public GameObject[] pages;
    private int currentPage = 0;

    public GameManager gameManager;

    public void NextPage()
    {
        currentPage++;
        ShowPage(currentPage);
    }

    public void Confirm()
    {
        gameObject.SetActive(false);
        gameManager.StartCountdown();
    }

    void ShowPage(int index)
    {
        for (int i = 0; i < pages.Length; i++)
            pages[i].SetActive(i == index);
    }
}
