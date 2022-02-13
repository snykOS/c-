[TestMethod]
public void ExportMyFile()
{
    Home.GoToFilesPage();
    CommonFiles.ViewFile(0);
    CommonFiles.ClickExport();

    //int result = CommonFiles.ClickExport();
    //Assert.AreEqual(1, result); ???
}

public static class CommonFiles
{
    private const string ExportButton = "exportBtn";      

    public static void ClickExport()
    {
        Driver.Click(ExportButton);
    }
}