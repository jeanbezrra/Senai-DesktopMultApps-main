using System.ComponentModel;

namespace MultApps.Client.Windows
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
        }
    }
}
private void txtAnoUltimoAniversario_Enter(object sender, EventArgs e)
{
    if (txtAnoNascimento.Text.Trim().Length < 4)
    {
        MessageBox.Show("É preciso informar o ANO DE " + "NASCIMENTO com 4 digitos", "Atenção!",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
        txtAnoNascimento.Focus();
    }
}
private void txtAnoUltimoAniversario_Validating(object
sender, CancelEventArgs e)
{
    if (Convert.ToInt32(txtAnoUltimoAniversario.Text) <=
    Convert.ToInt32(txtAnoNascimento.Text))
    {
        MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO " + "deve ser superior ao do ANO DE NASCIMENTO.",
"Atenção!",
MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Cancel = true;
    }
}