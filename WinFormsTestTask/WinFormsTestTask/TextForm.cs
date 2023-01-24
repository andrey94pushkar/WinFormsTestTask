namespace WinFormsTestTask
{
    public partial class TextForm : Form
    {
        internal event EventHandler BtnOkClicked;

        internal event EventHandler BtnCancelClacked;
        public  override string Text { get; set; } = "";
        public TextForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BtnCancelClacked.Invoke(this, EventArgs.Empty);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Text = textBox1.Text;
            BtnOkClicked.Invoke(this, EventArgs.Empty);
        }
    }
}
