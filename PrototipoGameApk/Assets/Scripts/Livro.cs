using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Livro : MonoBehaviour
{
    public TextMeshProUGUI texto1, texto2;
    Animator animation;

    private void Start()
    {
        animation = GetComponent<Animator>();
        setTextoPadrao();
    }

    public void PlaynextPage()
    {
        animation.SetBool("Next", true);
    }

    public void PlayBackPage()
    {
        animation.SetBool("Back", true);
    }

    public void endNextPage()
    {
        animation.SetBool("Next", false);
        texto1.GetComponent<TextMeshProUGUI>().text = "Oh, you can't help that,' said the Cat: we're all mad here. I'm mad. You're mad.'";
        texto2.GetComponent<TextMeshProUGUI>().text = "There is something delicious about writing the first words of a story. You never quite know where they'll take you.";
    }

    public void endBackPage()
    {
        animation.SetBool("Back", false);
        texto1.GetComponent<TextMeshProUGUI>().text = "“I like the cover,"+" he said. "+
            "Don't Panic. It's the first helpful or intelligible thing anybody's said to me all day.”";
        texto2.GetComponent<TextMeshProUGUI>().text = "“Well, everybody does it that way, Huck."+
        "Tom, I am not everybody.”";
    }

    public void setTextoPadrao()
    {
        texto1.GetComponent<TextMeshProUGUI>().text = "“I like the cover," + " he said. " +
            "Don't Panic. It's the first helpful or intelligible thing anybody's said to me all day.”";
        texto2.GetComponent<TextMeshProUGUI>().text = "“Well, everybody does it that way, Huck." +
        "Tom, I am not everybody.”";
    }
    


}
