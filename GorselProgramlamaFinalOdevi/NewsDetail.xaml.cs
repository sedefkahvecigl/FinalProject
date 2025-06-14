namespace GorselProgramlamaFinalOdevi;

public partial class NewsDetail : ContentPage
{
    private string newsUrl;
	public NewsDetail(string url)
	{
		InitializeComponent();

        newsUrl = url;
        webView.Source = url;
    }

    private async void ShareNews_Clicked(object sender, EventArgs e)
    {
        await Share.RequestAsync(new ShareTextRequest
        {
            Uri = newsUrl,
            Title = "Haberi Paylaþ"
        });
    }

    
}