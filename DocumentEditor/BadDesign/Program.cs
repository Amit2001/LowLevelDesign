namespace BadDesign
{
    public class Program
    {
        static void Main(string[] args)
        {
            DocElement doc = new DocElement();
            doc.AddText("Hello, World!");
            doc.AddImagePath("image.png");
            string output = doc.Render();
            Console.WriteLine(output);
            // doc.SaveToFile();
        }
    }

    public class DocElement
    {
        List<string> items = new List<string>();
        string renderedItem = "";

    public bool AddText(string text)
    {
        try
        {
            items.Add(text);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool AddImagePath(string path)
    {
        try
        {
            items.Add(path);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public string Render()
    {
        if(string.IsNullOrEmpty(renderedItem))
        {
            string documentToRender = "";
            foreach (var item in items)
            {
                if(item.Length > 4 && (item.Substring(item.Length - 4).ToLower() == ".png" || item.Substring(item.Length - 4).ToLower() == ".jpg"))
                {
                    documentToRender += "Image : "+ item + "\n";
                }
                else
                {
                    documentToRender += item + "\n";
                }
            }
            renderedItem = documentToRender;
        }
        return renderedItem;
    }

    public bool SaveToFile()
    {
        string filePath = "document.txt";
        try
        {
            System.IO.File.WriteAllText(filePath, renderedItem);
            return true;
        }
        catch
        {
            return false;
        }
    }
    }
}