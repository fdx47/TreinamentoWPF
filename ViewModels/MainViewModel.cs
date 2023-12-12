using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EvolizAPI.Services;
using System.Collections.ObjectModel;
using System.Windows;
using TreinamentoWPF.Models.Evoliz;
using TreinamentoWPF.Views;

namespace TreinamentoWPF.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        private async void AbrirJanelaCadProduto()
        {
            CadProdutoView view = new();
            view.ShowDialog();
        }
        [ObservableProperty]
        private ObservableCollection<Article> articles;
        [ObservableProperty]
        private ObservableCollection<ArticlesApiResponse> articlesApiResponse;
        [RelayCommand]
        private async Task BuscarProdutos()
        {
            ApiService service = new();
            var response = await service.GetArticles(1);
            int paginas = response.Meta.Total;
            if (response != null)
            {
                foreach (var article in response.Data)
                {
                    Articles ??= new();


                    Articles.Add(article);
                }
                //if (response.Meta.Total > 1)
                //{
                //    for (int i = 1; i < response.Meta.Total; i++)
                //    {
                //       await  BuscaProdutoPaginado(i);
                //    }
                //}
            }

        }
        private async Task BuscaProdutoPaginado(int page)
        {
            ApiService service = new();
            var response = await service.GetArticles(page);

            foreach (var article in response.Data)
            {
                Articles ??= new();

                Articles.Add(article);
            }
            //  MessageBox.Show("Paginas Carregadas", "Articles", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        [RelayCommand]
        private async Task Cadastrar()
        {
            using AppDbContext db = new();
            foreach (var article in Articles)
            {
                if (article.SaleClassification != null)
                {
                    db.SaleClassifications.Add(article.SaleClassification);
                    db.SaveChanges();
                }
                article.SaleClassification = null;
                db.Articles.Add(article);
                int result = +db.SaveChanges();
            }
            try
            {
                //  await db.SaveChangesAsync();
                // MessageBox.Show("Dados Gravados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
