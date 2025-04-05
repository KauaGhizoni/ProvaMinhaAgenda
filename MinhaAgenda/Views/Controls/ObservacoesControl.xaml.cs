namespace MinhaAgenda.Views.Controls
{
    public partial class ObservacoesControl : ContentView
    {
        public event EventHandler<string> OnError;
        public event EventHandler<EventArgs> OnSave;
        public event EventHandler<EventArgs> OnCancel;

        public ObservacoesControl()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get => entryTitulo.Text;
            set => entryTitulo.Text = value;
        }

        public string Descricao
        {
            get => entryDescricao.Text;
            set => entryDescricao.Text = value;
        }

        public DateTime Data
        {
            get => datePicker.Date;
            set => datePicker.Date = value;
        }

        public TimeSpan Hora
        {
            get => timePicker.Time;
            set => timePicker.Time = value;
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            if (tituloValidator.IsNotValid)
            {
                OnError?.Invoke(sender, "O título é obrigatório e deve ter no mínimo 3 caracteres.");
                return;
            }

            OnSave?.Invoke(sender, e);
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            OnCancel?.Invoke(sender, e);
        }
    }
}
