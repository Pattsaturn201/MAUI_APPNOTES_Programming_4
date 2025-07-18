namespace EdwinSaaNotesD.Views;

public partial class NotePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public NotePage()
	{
        InitializeComponent();
       
    }

    public void LoadNote (string filename) 
    {
        Models.Note noteModel = new Models.Note();
        noteModel.Filename = filename;


    }
    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Guarda el archivo.
        File.WriteAllText(_fileName, TextEditor.Text);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        // Elimina el archivo.
        if (File.Exists(_fileName))
            File.Delete(_fileName);
        TextEditor.Text = string.Empty;
    }
}