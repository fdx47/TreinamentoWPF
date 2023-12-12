using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Media.Imaging;
using TreinamentoWPF.Models;
using TreinamentoWPF.Utilitarios;

namespace TreinamentoWPF.ViewModels
{
    public partial class CadProdutoViewModel : ViewModelBase
    {
        [ObservableProperty]
        private Produto produto = new();
        [ObservableProperty]
        private BitmapImage? imagem;
        [RelayCommand]
        private async void Salvar()
        {
            using var db = new AppDbContext();
            db.Produtos.Add(produto);
            try
            {
                var result = await db.SaveChangesAsync();
                if (result > 0)
                {
                    MessageBox.Show("Produto Cadastrado com sucesso!", "Cadastro", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        [RelayCommand]
        private async void SelecionarImagem()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Imagens|*.jpg;*.png;*.gif;*.bmp";
            if (dialog.ShowDialog() == true && !string.IsNullOrEmpty(dialog.FileName))
            {
                Imagem = new BitmapImage(new Uri(dialog.FileName));
                Produto.Imagem = Utils.ConvertBitmapSourceToByteArray(dialog.FileName);
            }
        }
        [RelayCommand]
        private void RemoverImagem()
        {
            Produto.Imagem = null;
        }
    }
}
