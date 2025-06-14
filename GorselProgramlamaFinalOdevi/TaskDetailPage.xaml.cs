using GorselProgramlamaFinalOdevi.Models;

namespace GorselProgramlamaFinalOdevi;

public partial class TaskDetailPage : ContentPage
{
    private Notes _note;

public TaskDetailPage(Notes note)
    {
        InitializeComponent();
        _note = note;

        // Mevcut deðerleri kutulara yükle
        titleEntry.Text = _note.Title;
        detailEditor.Text = _note.NoteContent;
        datePicker.Date = _note.Date;
        timePicker.Time = _note.Time;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        _note.Title = titleEntry.Text;
        _note.NoteContent = detailEditor.Text;
        _note.Date = datePicker.Date;
        _note.Time = timePicker.Time;

        BL.EditNote(_note);

        await DisplayAlert("Kaydedildi", "Görev güncellendi", "Tamam");
        await Navigation.PopAsync(); // Sayfayý geri kapat
    }
}