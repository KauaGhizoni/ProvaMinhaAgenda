using CasosDeUso.Interface;
using CoreBusiness.Entidades;

namespace MinhaAgenda.Views;

public partial class AdicionarObservacaoPage : ContentPage
{
    private readonly IAdicionarObservacaoUseCase _adicionarObservacaoUseCase;

    public AdicionarObservacaoPage(IAdicionarObservacaoUseCase adicionarObservacaoUseCase)
    {
        InitializeComponent();
        _adicionarObservacaoUseCase = adicionarObservacaoUseCase;
    }

    private async void observacoesCtrl_OnSave(object sender, EventArgs e)
    {
        var data = observacoesCtrl.Data;
        var hora = observacoesCtrl.Hora;
        var dataHora = new DateTime(
            data.Year,
            data.Month,
            data.Day,
            hora.Hours,
            hora.Minutes,
            0);

        var novaObservacao = new Observacao(observacoesCtrl.Titulo, observacoesCtrl.Descricao, dataHora);

        await _adicionarObservacaoUseCase.ExecutaAsync(novaObservacao);
        await Shell.Current.GoToAsync($"//{nameof(ContatosPage)}");
    }
}
