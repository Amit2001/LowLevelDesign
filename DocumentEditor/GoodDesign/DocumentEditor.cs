public class DocumentEditor
{
    public static void Main(string[] args)
    {
        Document document = new Document();
        document.AddText("Hello, World!");
        document.AddImagePath("image.png");
        string output = document.Render();
        Console.WriteLine(output);
    }
}

public interface IDocumentElement
{
    public string Render();
}

public class TextElement : IDocumentElement
{
    private string text;

    public TextElement(string text)
    {
        this.text = text;
    }

    public string Render()
    {
        return text + '\n';
    }
}

public class ImageElement : IDocumentElement
{
    private string path;

    public ImageElement(string path)
    {
        this.path = path;
    }

    public string Render()
    {
        return "Image : " + path + '\n';
    }
}   

public class Document
{
    private List<IDocumentElement> elements = new List<IDocumentElement>();

    public void AddText(string text)
    {
        elements.Add(new TextElement(text));
    }

    public void AddImagePath(string path)
    {
        elements.Add(new ImageElement(path));
    }

    public string Render()
    {
        string documentToRender = "";
        foreach (var element in elements)
        {
            documentToRender += element.Render();
        }
        return documentToRender;
    }
}